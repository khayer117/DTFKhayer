using Starcounter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTFKhayer.ViewModels;
using DTFKhayerEntity;

namespace DTFKhayer
{
    public class RegisterMainHandlers : IHandler
    {
        private readonly IFranchiseService _franchiseService;

        public RegisterMainHandlers()
        {
            this._franchiseService = new FranchiseService();
        }

        public void Register()
        {
            Application.Current.Use(new HtmlFromJsonProvider());
            Application.Current.Use(new PartialToStandaloneHtmlProvider());

            Handle.GET("/DTFKhayer", () =>
            {
                return Db.Scope(() =>
                {
                    //var corporation = Db.SQL<Corporation>("SELECT p FROM Corporation p").First;
                    var corporation = new Corporation()
                    {
                        Name = ""
                    };
                    var json = new SetupPage()
                    {
                        Data = corporation
                    };

                    if (Session.Current == null)
                    {
                        Session.Current = new Session(SessionOptions.PatchVersioning);
                    }
                    json.Session = Session.Current;
                    return json;
                });

            });

            Handle.GET("/DTFKhayer/Coporation/{?}", (string key) =>
            {
                return Db.Scope(() =>
                {
                    var corporation = Db.SQL<Corporation>("SELECT p FROM Corporation p where p.ObjectId=?",key).First;
                    var json = new SetupPage()
                    {
                        Data = corporation
                    };

                    if (Session.Current == null)
                    {
                        Session.Current = new Session(SessionOptions.PatchVersioning);
                    }
                    json.Session = Session.Current;
                    return json;
                });

            });

            Handle.GET("/DTFKhayer/Franchise/{?}", (string key) =>
            {
                return Db.Scope(() =>
                {

                    var franchiseSetting = this._franchiseService.GetFranchise(key);
                    var json = new FranchiseDetailsPage()
                    {
                        Data = franchiseSetting
                    };

                    if (Session.Current == null)
                    {
                        Session.Current = new Session(SessionOptions.PatchVersioning);
                    }
                    json.Session = Session.Current;
                    return json;
                });

            });

        }
    }
}
