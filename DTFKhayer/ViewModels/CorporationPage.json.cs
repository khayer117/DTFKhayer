using DTFKhayerEntity;
using Starcounter;

namespace DTFKhayer
{
    partial class CorporationPage : Json
    {
        static CorporationPage()
        {
            DefaultTemplate.Franchises.ElementType.InstanceType = typeof(FranchiseListPage);
        }

        void Handle(Input.FranchiseSaveTrigger action)
        {
            new Franchise()
            {
                Corporation = this.Data as Corporation,
                Name = this.NewFranchiseName
            };
            Transaction.Commit();
        }
    }
}
