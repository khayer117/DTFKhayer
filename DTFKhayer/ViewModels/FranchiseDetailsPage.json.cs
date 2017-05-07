using Starcounter;

namespace DTFKhayer
{
    partial class FranchiseDetailsPage : Json
    {
        void Handle(Input.SaveSettingTrigger action)
        {
            Transaction.Commit();
        }
    }
}
