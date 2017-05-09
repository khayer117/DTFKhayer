using DTFKhayer.Services;
using DTFKhayerEntity;
using Starcounter;

namespace DTFKhayer
{
    partial class FranchiseListPage : Json,IBound<Franchise>
    {
        protected override void OnData()
        {
            base.OnData();

            this.Key = this.Data.GetObjectID();

            var franchiseService = new FranchiseService();
            var franchise = franchiseService.GetFranchise(this.Key);
            this.TotalHomeSold = GetTotalHomeSold(franchise);
            this.TotalCommission = GetTotalCommission(franchise);
            this.AverageCommission = GetAvgCommission(franchise);
            this.Trend = GetTrend(franchise);
        }

        private long GetTotalHomeSold(Franchise franchise)
        {
            return Db.SQL<long>("SELECT COUNT(h.Number) FROM Home h WHERE h.Franchise = ?", franchise).First;
        }

        private long GetTotalCommission(Franchise franchise)
        {
            return Db.SQL<long>("SELECT SUM(s.Commission) FROM Sale s WHERE s.Franchise = ?", franchise).First;
        }

        private decimal GetAvgCommission(Franchise franchise)
        {
            return Db.SQL<decimal>("SELECT AVG(s.Commission) FROM Sale s WHERE s.Franchise = ?", franchise).First;
        }

        private long GetTrend(Franchise franchise)
        {
            var trendCalculator = new TrendCalculator();
            return trendCalculator.Calculate(franchise);
        }
    }
}
