using System;
using System.Linq;
using DTFKhayerEntity;
using Starcounter;

namespace DTFKhayer.ViewModels
{
    partial class SetupPage : Json,IBound<Corporation>
    {
        protected override void OnData()
        {
            base.OnData();
            LoadCorporates();
        }

        static SetupPage()
        {
            DefaultTemplate.Corporates.ElementType.InstanceType = typeof(CorporationPage);
        }

        void Handle(Input.SaveCorporationTrigger action)
        {
            this.Data.EntryDate = DateTime.Now;
            Transaction.Commit();
            LoadCorporates();
        }

        private void LoadCorporates()
        {
            this.Corporates = Db.SQL<Corporation>("SELECT c FROM Corporation c ORDER BY c.EntryDate");

            this.IsShowCorporate = this.Corporates.Where(item=>!string.IsNullOrEmpty(item.Name)).ToList().Count > 0;
        }

    }
}
