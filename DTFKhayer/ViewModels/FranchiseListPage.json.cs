using System;
using System.Collections.Generic;
using System.Linq;
using DTFKhayer.Services;
using DTFKhayerEntity;
using Starcounter;
using Starcounter.XSON.Interfaces;

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
            // Getting unwanted exception for version 2.4 nightly build 05/07/2007
            //return Db.SQL<decimal>("SELECT AVG(s.Commission) FROM Sale s WHERE s.Franchise = ?", franchise).First;

            var sales = Db.SQL<Sale>("SELECT s FROM Sale s WHERE s.Franchise = ?", franchise);
            var avg = sales.Count()>0 ? sales.Select(item => (decimal) item.Commission).ToList().Average():0;

            return Math.Round(avg,2);
        }

        private long GetTrend(Franchise franchise)
        {
            var sales = Db.SQL<Sale>("SELECT s FROM Sale s WHERE s.Franchise = ? ORDER BY s.SalesDate", franchise);

            var minSalesDate = sales.Any()? sales.Min(s => s.SalesDate):DateTime.Today;

            var values = sales.GroupBy(d=>d.SalesDate).Select(item => new TrendDataItem()
            {
                X = (item.Key-minSalesDate).Days,
                Y = item.Sum(c=>c.Commission)
            });

            var trendCalculator = new TrendCalculator();
            return trendCalculator.Calculate(values);
        }
    }
}
