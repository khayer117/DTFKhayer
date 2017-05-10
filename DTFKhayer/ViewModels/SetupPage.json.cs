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

            Transaction.Commit();
            LoadCorporates();
        }

        private void LoadCorporates()
        {
            this.Corporates = Db.SQL<Corporation>("SELECT c FROM Corporation c");
        }

    }
}
