using System.Runtime.CompilerServices;
using DTFKhayerEntity;
using Starcounter;

namespace DTFKhayer
{
    partial class SalesListPage : Json, IBound<Sale>
    {

        protected override void OnData()
        {
            base.OnData();

            this.Address = this.Data.Home.Address;
        }

    }
}
