// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "ViewModels\FranchiseDetailsPage.json"
// Version: 2004
// DO NOT MODIFY DIRECTLY - CHANGES WILL BE OVERWRITTEN

using System;
using System.Collections;
using System.Collections.Generic;
using Starcounter.Advanced;
using Starcounter;
using Starcounter.Internal;
using Starcounter.Templates;
using Starcounter.XSON;
using DTFKhayer.Services;
using DTFKhayerEntity;
#pragma warning disable 0108
#pragma warning disable 1591

namespace DTFKhayer {
using __FrNumber__ = global::DTFKhayer.FranchiseDetailsPage.Input.Number;
using __FrCity__ = global::DTFKhayer.FranchiseDetailsPage.Input.City;
using __FrCountry__ = global::DTFKhayer.FranchiseDetailsPage.Input.Country;
using __FrHomeStre__ = global::DTFKhayer.FranchiseDetailsPage.Input.HomeStreet;
using __FrHomeNumb__ = global::DTFKhayer.FranchiseDetailsPage.Input.HomeNumber;
using __FrHomeZipC__ = global::DTFKhayer.FranchiseDetailsPage.Input.HomeZipCode;
using __FrHomeCity__ = global::DTFKhayer.FranchiseDetailsPage.Input.HomeCity;
using __FrHomeCoun__ = global::DTFKhayer.FranchiseDetailsPage.Input.HomeCountry;
using __FrZipCode__ = global::DTFKhayer.FranchiseDetailsPage.Input.ZipCode;
using __FrSalesDat__ = global::DTFKhayer.FranchiseDetailsPage.Input.SalesDate;
using __FrCommissi__ = global::DTFKhayer.FranchiseDetailsPage.Input.Commission;
using __FrCoporati__ = global::DTFKhayer.FranchiseDetailsPage.Input.CoporationKey;
using __FrSaveSett__ = global::DTFKhayer.FranchiseDetailsPage.Input.SaveSettingTrigger;
using __FrSaveRegi__ = global::DTFKhayer.FranchiseDetailsPage.Input.SaveRegisterTrigger;
using s = Starcounter;
using st = Starcounter.Templates;
using _ScTemplate_ = Starcounter.Templates.Template;
using __FrPrice__ = global::DTFKhayer.FranchiseDetailsPage.Input.Price;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __FrName__ = global::DTFKhayer.FranchiseDetailsPage.Input.Name;
using __Franchis__ = global::DTFKhayer.FranchiseDetailsPage;
using __Json__ = global::Starcounter.Json;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __FrSchema__ = global::DTFKhayer.FranchiseDetailsPage.JsonByExample.Schema;
using __TString__ = global::Starcounter.Templates.TString;
using __FrStreet__ = global::DTFKhayer.FranchiseDetailsPage.Input.Street;
using __TLong__ = global::Starcounter.Templates.TLong;
using __SaSchema__ = SalesListPage.JsonByExample.Schema;
using __SalesLis1__ = SalesListPage.JsonByExample;
using __TArray__ = global::Starcounter.Templates.TArray<SalesListPage>;
using __Franchis1__ = global::DTFKhayer.FranchiseDetailsPage.JsonByExample;
using __Arr__ = global::Starcounter.Arr<SalesListPage>;
using __Franchis2__ = global::DTFKhayer.FranchiseDetailsPage.Input;
using __FrHtml__ = global::DTFKhayer.FranchiseDetailsPage.Input.Html;
using __SalesLis__ = SalesListPage;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class FranchiseDetailsPage_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class FranchiseDetailsPage : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __FrSchema__ DefaultTemplate = new __FrSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public FranchiseDetailsPage() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public FranchiseDetailsPage(__FrSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __FrSchema__ Template { get { return (__FrSchema__)base.Template; } set { base.Template = value; } }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new Franchise Data { get { return (Franchise)base.Data; } set { base.Data = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__Franchis__);
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/DTFKhayer/viewmodels/FranchiseDetailsPage.html";
                Html.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Name = Add<__TString__>("Name$");
                Name.DefaultValue = "";
                Name.Editable = true;
                Name.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                Street = Add<__TString__>("Street$");
                Street.DefaultValue = "";
                Street.Editable = true;
                Street.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Street__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Street__ = (System.String)_v_; }, false);
                Number = Add<__TString__>("Number$");
                Number.DefaultValue = "";
                Number.Editable = true;
                Number.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Number__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Number__ = (System.String)_v_; }, false);
                ZipCode = Add<__TString__>("ZipCode$");
                ZipCode.DefaultValue = "";
                ZipCode.Editable = true;
                ZipCode.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__ZipCode__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__ZipCode__ = (System.String)_v_; }, false);
                City = Add<__TString__>("City$");
                City.DefaultValue = "";
                City.Editable = true;
                City.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__City__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__City__ = (System.String)_v_; }, false);
                Country = Add<__TString__>("Country$");
                Country.DefaultValue = "";
                Country.Editable = true;
                Country.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Country__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Country__ = (System.String)_v_; }, false);
                HomeStreet = Add<__TString__>("HomeStreet$");
                HomeStreet.DefaultValue = "";
                HomeStreet.Editable = true;
                HomeStreet.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__HomeStreet__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__HomeStreet__ = (System.String)_v_; }, false);
                HomeNumber = Add<__TString__>("HomeNumber$");
                HomeNumber.DefaultValue = "";
                HomeNumber.Editable = true;
                HomeNumber.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__HomeNumber__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__HomeNumber__ = (System.String)_v_; }, false);
                HomeZipCode = Add<__TString__>("HomeZipCode$");
                HomeZipCode.DefaultValue = "";
                HomeZipCode.Editable = true;
                HomeZipCode.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__HomeZipCode__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__HomeZipCode__ = (System.String)_v_; }, false);
                HomeCity = Add<__TString__>("HomeCity$");
                HomeCity.DefaultValue = "";
                HomeCity.Editable = true;
                HomeCity.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__HomeCity__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__HomeCity__ = (System.String)_v_; }, false);
                HomeCountry = Add<__TString__>("HomeCountry$");
                HomeCountry.DefaultValue = "";
                HomeCountry.Editable = true;
                HomeCountry.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__HomeCountry__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__HomeCountry__ = (System.String)_v_; }, false);
                SalesDate = Add<__TString__>("SalesDate$");
                SalesDate.DefaultValue = "";
                SalesDate.Editable = true;
                SalesDate.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__SalesDate__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__SalesDate__ = (System.String)_v_; }, false);
                Price = Add<__TLong__>("Price$");
                Price.DefaultValue = 0L;
                Price.Editable = true;
                Price.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Price__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Price__ = (System.Int64)_v_; }, false);
                Commission = Add<__TLong__>("Commission$");
                Commission.DefaultValue = 0L;
                Commission.Editable = true;
                Commission.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Commission__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Commission__ = (System.Int64)_v_; }, false);
                Sales = Add<__TArray__>("Sales");
                Sales.SetCustomGetElementType((arr) => { return __SalesLis__.DefaultTemplate;});
                Sales.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Sales__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Sales__ = (__Arr__)_v_; }, false);
                CoporationKey = Add<__TString__>("CoporationKey");
                CoporationKey.DefaultValue = "";
                CoporationKey.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__CoporationKey__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__CoporationKey__ = (System.String)_v_; }, false);
                SaveSettingTrigger = Add<__TLong__>("SaveSettingTrigger$");
                SaveSettingTrigger.DefaultValue = 0L;
                SaveSettingTrigger.Editable = true;
                SaveSettingTrigger.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__SaveSettingTrigger__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__SaveSettingTrigger__ = (System.Int64)_v_; }, false);
                SaveSettingTrigger.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.SaveSettingTrigger() { App = (FranchiseDetailsPage)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((FranchiseDetailsPage)pup).Handle((Input.SaveSettingTrigger)input); });
                SaveRegisterTrigger = Add<__TLong__>("SaveRegisterTrigger$");
                SaveRegisterTrigger.DefaultValue = 0L;
                SaveRegisterTrigger.Editable = true;
                SaveRegisterTrigger.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__SaveRegisterTrigger__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__SaveRegisterTrigger__ = (System.Int64)_v_; }, false);
                SaveRegisterTrigger.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.SaveRegisterTrigger() { App = (FranchiseDetailsPage)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((FranchiseDetailsPage)pup).Handle((Input.SaveRegisterTrigger)input); });
            }
            public override object CreateInstance(s.Json parent) { return new __Franchis__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ Name;
            public __TString__ Street;
            public __TString__ Number;
            public __TString__ ZipCode;
            public __TString__ City;
            public __TString__ Country;
            public __TString__ HomeStreet;
            public __TString__ HomeNumber;
            public __TString__ HomeZipCode;
            public __TString__ HomeCity;
            public __TString__ HomeCountry;
            public __TString__ SalesDate;
            public __TLong__ Price;
            public __TLong__ Commission;
            public __TArray__ Sales;
            public __TString__ CoporationKey;
            public __TLong__ SaveSettingTrigger;
            public __TLong__ SaveRegisterTrigger;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "ViewModels\FranchiseDetailsPage.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "ViewModels\FranchiseDetailsPage.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Name__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Name {
    #line 3 "ViewModels\FranchiseDetailsPage.json"
        get {
        #line hidden
            return Template.Name.Getter(this); }
        #line 3 "ViewModels\FranchiseDetailsPage.json"
        set {
        #line hidden
            Template.Name.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Street__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Street {
    #line 4 "ViewModels\FranchiseDetailsPage.json"
        get {
        #line hidden
            return Template.Street.Getter(this); }
        #line 4 "ViewModels\FranchiseDetailsPage.json"
        set {
        #line hidden
            Template.Street.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Number__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Number {
    #line 5 "ViewModels\FranchiseDetailsPage.json"
        get {
        #line hidden
            return Template.Number.Getter(this); }
        #line 5 "ViewModels\FranchiseDetailsPage.json"
        set {
        #line hidden
            Template.Number.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__ZipCode__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String ZipCode {
    #line 6 "ViewModels\FranchiseDetailsPage.json"
        get {
        #line hidden
            return Template.ZipCode.Getter(this); }
        #line 6 "ViewModels\FranchiseDetailsPage.json"
        set {
        #line hidden
            Template.ZipCode.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__City__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String City {
    #line 7 "ViewModels\FranchiseDetailsPage.json"
        get {
        #line hidden
            return Template.City.Getter(this); }
        #line 7 "ViewModels\FranchiseDetailsPage.json"
        set {
        #line hidden
            Template.City.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Country__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Country {
    #line 8 "ViewModels\FranchiseDetailsPage.json"
        get {
        #line hidden
            return Template.Country.Getter(this); }
        #line 8 "ViewModels\FranchiseDetailsPage.json"
        set {
        #line hidden
            Template.Country.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__HomeStreet__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String HomeStreet {
    #line 10 "ViewModels\FranchiseDetailsPage.json"
        get {
        #line hidden
            return Template.HomeStreet.Getter(this); }
        #line 10 "ViewModels\FranchiseDetailsPage.json"
        set {
        #line hidden
            Template.HomeStreet.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__HomeNumber__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String HomeNumber {
    #line 11 "ViewModels\FranchiseDetailsPage.json"
        get {
        #line hidden
            return Template.HomeNumber.Getter(this); }
        #line 11 "ViewModels\FranchiseDetailsPage.json"
        set {
        #line hidden
            Template.HomeNumber.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__HomeZipCode__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String HomeZipCode {
    #line 12 "ViewModels\FranchiseDetailsPage.json"
        get {
        #line hidden
            return Template.HomeZipCode.Getter(this); }
        #line 12 "ViewModels\FranchiseDetailsPage.json"
        set {
        #line hidden
            Template.HomeZipCode.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__HomeCity__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String HomeCity {
    #line 13 "ViewModels\FranchiseDetailsPage.json"
        get {
        #line hidden
            return Template.HomeCity.Getter(this); }
        #line 13 "ViewModels\FranchiseDetailsPage.json"
        set {
        #line hidden
            Template.HomeCity.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__HomeCountry__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String HomeCountry {
    #line 14 "ViewModels\FranchiseDetailsPage.json"
        get {
        #line hidden
            return Template.HomeCountry.Getter(this); }
        #line 14 "ViewModels\FranchiseDetailsPage.json"
        set {
        #line hidden
            Template.HomeCountry.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__SalesDate__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String SalesDate {
    #line 16 "ViewModels\FranchiseDetailsPage.json"
        get {
        #line hidden
            return Template.SalesDate.Getter(this); }
        #line 16 "ViewModels\FranchiseDetailsPage.json"
        set {
        #line hidden
            Template.SalesDate.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__Price__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 Price {
    #line 17 "ViewModels\FranchiseDetailsPage.json"
        get {
        #line hidden
            return Template.Price.Getter(this); }
        #line 17 "ViewModels\FranchiseDetailsPage.json"
        set {
        #line hidden
            Template.Price.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__Commission__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 Commission {
    #line 18 "ViewModels\FranchiseDetailsPage.json"
        get {
        #line hidden
            return Template.Commission.Getter(this); }
        #line 18 "ViewModels\FranchiseDetailsPage.json"
        set {
        #line hidden
            Template.Commission.Setter(this, value); } }
        #line default
    #line hidden
    private __Arr__ __bf__Sales__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ Sales {
    #line 20 "ViewModels\FranchiseDetailsPage.json"
        get {
        #line hidden
            return Template.Sales.Getter(this); }
        #line 20 "ViewModels\FranchiseDetailsPage.json"
        set {
        #line hidden
            Template.Sales.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__CoporationKey__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String CoporationKey {
    #line 22 "ViewModels\FranchiseDetailsPage.json"
        get {
        #line hidden
            return Template.CoporationKey.Getter(this); }
        #line 22 "ViewModels\FranchiseDetailsPage.json"
        set {
        #line hidden
            Template.CoporationKey.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__SaveSettingTrigger__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 SaveSettingTrigger {
    #line 24 "ViewModels\FranchiseDetailsPage.json"
        get {
        #line hidden
            return Template.SaveSettingTrigger.Getter(this); }
        #line 24 "ViewModels\FranchiseDetailsPage.json"
        set {
        #line hidden
            Template.SaveSettingTrigger.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__SaveRegisterTrigger__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 SaveRegisterTrigger {
    #line 25 "ViewModels\FranchiseDetailsPage.json"
        get {
        #line hidden
            return Template.SaveRegisterTrigger.Getter(this); }
        #line 25 "ViewModels\FranchiseDetailsPage.json"
        set {
        #line hidden
            Template.SaveRegisterTrigger.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Name : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Street : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Number : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class ZipCode : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class City : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Country : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class HomeStreet : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class HomeNumber : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class HomeZipCode : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class HomeCity : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class HomeCountry : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class SalesDate : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Price : Input<__Franchis__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class Commission : Input<__Franchis__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class CoporationKey : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class SaveSettingTrigger : Input<__Franchis__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class SaveRegisterTrigger : Input<__Franchis__, __TLong__, long> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
