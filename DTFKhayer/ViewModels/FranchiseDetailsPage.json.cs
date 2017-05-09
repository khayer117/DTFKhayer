using System;
using DTFKhayerEntity;
using Starcounter;

namespace DTFKhayer
{
    partial class FranchiseDetailsPage : Json
    {
        void Handle(Input.SaveSettingTrigger action)
        {
            Transaction.Commit();
        }
        void Handle(Input.SaveRegisterTrigger action)
        {
            var franchiseService = new FranchiseService();
            var franchise = franchiseService.GetFranchise("test office");

            Db.Transact(() =>
            {
                // new Home
                var home = new Home()
                {
                    //Franchise = this.Data as Franchise,
                    Franchise = franchise,
                    Street = this.HomeStreet,
                    City = this.HomeCity,
                    Country = this.HomeCountry,
                    Number = this.HomeNumber
                };

                // new transaction
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
