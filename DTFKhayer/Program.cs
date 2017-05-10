using System;
using System.Collections.Generic;
using DTFKhayer.Services;
using Starcounter;
using DTFKhayerEntity;

namespace DTFKhayer
{
    class Program
    {
        static void Main()
        {
            var mainHandler = new RegisterMainHandlers();
            mainHandler.Register();

        }
    }
}