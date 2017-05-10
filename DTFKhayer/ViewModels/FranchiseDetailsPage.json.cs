using System;
using DTFKhayer.Services;
using DTFKhayerEntity;
using Starcounter;

namespace DTFKhayer
{
    partial class FranchiseDetailsPage : Json, IBound<Franchise>
    {
        protected override void OnData()
        {
            base.OnData();

            this.CoporationKey = this.Data.Corporation.GetObjectID();
        }

        static FranchiseDetailsPage()
        {
            DefaultTemplate.Sales.ElementType.InstanceType = typeof(SalesListPage);
        }
        void Handle(Input.SaveSettingTrigger action)
        {
            Transaction.Commit();
        }
        void Handle(Input.SaveRegisterTrigger action)
        {
            var franchiseService = new FranchiseService();
            var franchise = franchiseService.GetFranchise(this.Data.GetObjectID());

            Db.Transact(() =>
            {
                var home = new Home()
                {
                    Franchise = franchise,
                    Street = this.HomeStreet,
                    City = this.HomeCity,
                    Country = this.HomeCountry,
                    Number = this.HomeNumber
                };

                new Sale()
                {
                    Home = home,
                    Franchise = franchise,
                    Commission = this.Commission,
                    Price = this.Price,
                    SalesDate = DateTime.Parse(this.SalesDate)
                };
            });

            Transaction.Commit();
        }

    }
}
