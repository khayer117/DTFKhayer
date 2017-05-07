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
#pragma warning disable 0108
#pragma warning disable 1591

namespace DTFKhayer {
using __FrHtml__ = global::DTFKhayer.FranchiseDetailsPage.Input.Html;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __FrSaveSett__ = global::DTFKhayer.FranchiseDetailsPage.Input.SaveSettingTrigger;
using __FrCountry__ = global::DTFKhayer.FranchiseDetailsPage.Input.Country;
using __FrCity__ = global::DTFKhayer.FranchiseDetailsPage.Input.City;
using __FrZipCode__ = global::DTFKhayer.FranchiseDetailsPage.Input.ZipCode;
using __FrNumber__ = global::DTFKhayer.FranchiseDetailsPage.Input.Number;
using __FrStreet__ = global::DTFKhayer.FranchiseDetailsPage.Input.Street;
using __FrName__ = global::DTFKhayer.FranchiseDetailsPage.Input.Name;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __Franchis2__ = global::DTFKhayer.FranchiseDetailsPage.Input;
using __Franchis1__ = global::DTFKhayer.FranchiseDetailsPage.JsonByExample;
using __TLong__ = global::Starcounter.Templates.TLong;
using __TString__ = global::Starcounter.Templates.TString;
using __FrSchema__ = global::DTFKhayer.FranchiseDetailsPage.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __Franchis__ = global::DTFKhayer.FranchiseDetailsPage;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;

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
                SaveSettingTrigger = Add<__TLong__>("SaveSettingTrigger$");
                SaveSettingTrigger.DefaultValue = 0L;
                SaveSettingTrigger.Editable = true;
                SaveSettingTrigger.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__SaveSettingTrigger__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__SaveSettingTrigger__ = (System.Int64)_v_; }, false);
                SaveSettingTrigger.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.SaveSettingTrigger() { App = (FranchiseDetailsPage)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((FranchiseDetailsPage)pup).Handle((Input.SaveSettingTrigger)input); });
            }
            public override object CreateInstance(s.Json parent) { return new __Franchis__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ Name;
            public __TString__ Street;
            public __TString__ Number;
            public __TString__ ZipCode;
            public __TString__ City;
            public __TString__ Country;
            public __TLong__ SaveSettingTrigger;
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
    private System.Int64 __bf__SaveSettingTrigger__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 SaveSettingTrigger {
    #line 9 "ViewModels\FranchiseDetailsPage.json"
        get {
        #line hidden
            return Template.SaveSettingTrigger.Getter(this); }
        #line 9 "ViewModels\FranchiseDetailsPage.json"
        set {
        #line hidden
            Template.SaveSettingTrigger.Setter(this, value); } }
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
        public class SaveSettingTrigger : Input<__Franchis__, __TLong__, long> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
