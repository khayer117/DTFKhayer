using System;
using Starcounter;
using DTFKhayerEntity;

namespace DTFKhayer
{
    class Program
    {
        static void Main()
        {
            //Db.Transact(() =>
            //{
            //    var anyone = Db.SQL<Corporation>("SELECT p FROM Corporation p").First;
            //    if (anyone == null)
            //    {
            //        new Corporation
            //        {
            //            Name = "TestCoporation"
            //        };
            //    }
            //});

            var mainHandler = new RegisterMainHandlers();
            mainHandler.Register();

        }
    }
}