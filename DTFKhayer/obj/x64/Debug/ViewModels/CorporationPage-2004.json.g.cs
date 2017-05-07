// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "ViewModels\CorporationPage.json"
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
using DTFKhayerEntity;
#pragma warning disable 0108
#pragma warning disable 1591

namespace DTFKhayer {
using __TLong__ = global::Starcounter.Templates.TLong;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __CoFranchis__ = global::DTFKhayer.CorporationPage.Input.FranchiseSaveTrigger;
using __CoSaveCorp__ = global::DTFKhayer.CorporationPage.Input.SaveCorporationTrigger;
using __CoNewFranc__ = global::DTFKhayer.CorporationPage.Input.NewFranchiseName;
using __CoName__ = global::DTFKhayer.CorporationPage.Input.Name;
using __CoHtml__ = global::DTFKhayer.CorporationPage.Input.Html;
using __Corporat2__ = global::DTFKhayer.CorporationPage.Input;
using __Arr__ = global::Starcounter.Arr<FranchiseListPage>;
using __Corporat1__ = global::DTFKhayer.CorporationPage.JsonByExample;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __TArray__ = global::Starcounter.Templates.TArray<FranchiseListPage>;
using __Franchis1__ = FranchiseListPage.JsonByExample;
using __FrSchema__ = FranchiseListPage.JsonByExample.Schema;
using __Franchis__ = FranchiseListPage;
using __TString__ = global::Starcounter.Templates.TString;
using __CoSchema__ = global::DTFKhayer.CorporationPage.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __Corporat__ = global::DTFKhayer.CorporationPage;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class CorporationPage_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class CorporationPage : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __CoSchema__ DefaultTemplate = new __CoSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public CorporationPage() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public CorporationPage(__CoSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __CoSchema__ Template { get { return (__CoSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__Corporat__);
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/DTFKhayer/viewmodels/CorporationPage.html";
                Html.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Name = Add<__TString__>("Name$");
                Name.DefaultValue = "";
                Name.Editable = true;
                Name.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                Franchises = Add<__TArray__>("Franchises");
                Franchises.SetCustomGetElementType((arr) => { return __Franchis__.DefaultTemplate;});
                Franchises.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__Franchises__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__Franchises__ = (__Arr__)_v_; }, false);
                NewFranchiseName = Add<__TString__>("NewFranchiseName$");
                NewFranchiseName.DefaultValue = "";
                NewFranchiseName.Editable = true;
                NewFranchiseName.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__NewFranchiseName__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__NewFranchiseName__ = (System.String)_v_; }, false);
                SaveCorporationTrigger = Add<__TLong__>("SaveCorporationTrigger$");
                SaveCorporationTrigger.DefaultValue = 0L;
                SaveCorporationTrigger.Editable = true;
                SaveCorporationTrigger.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__SaveCorporationTrigger__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__SaveCorporationTrigger__ = (System.Int64)_v_; }, false);
                SaveCorporationTrigger.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.SaveCorporationTrigger() { App = (CorporationPage)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((CorporationPage)pup).Handle((Input.SaveCorporationTrigger)input); });
                FranchiseSaveTrigger = Add<__TLong__>("FranchiseSaveTrigger$");
                FranchiseSaveTrigger.DefaultValue = 0L;
                FranchiseSaveTrigger.Editable = true;
                FranchiseSaveTrigger.SetCustomAccessors((_p_) => { return ((__Corporat__)_p_).__bf__FranchiseSaveTrigger__; }, (_p_, _v_) => { ((__Corporat__)_p_).__bf__FranchiseSaveTrigger__ = (System.Int64)_v_; }, false);
                FranchiseSaveTrigger.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.FranchiseSaveTrigger() { App = (CorporationPage)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((CorporationPage)pup).Handle((Input.FranchiseSaveTrigger)input); });
            }
            public override object CreateInstance(s.Json parent) { return new __Corporat__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ Name;
            public __TArray__ Franchises;
            public __TString__ NewFranchiseName;
            public __TLong__ SaveCorporationTrigger;
            public __TLong__ FranchiseSaveTrigger;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "ViewModels\CorporationPage.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "ViewModels\CorporationPage.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Name__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Name {
    #line 3 "ViewModels\CorporationPage.json"
        get {
        #line hidden
            return Template.Name.Getter(this); }
        #line 3 "ViewModels\CorporationPage.json"
        set {
        #line hidden
            Template.Name.Setter(this, value); } }
        #line default
    #line hidden
    private __Arr__ __bf__Franchises__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ Franchises {
    #line 4 "ViewModels\CorporationPage.json"
        get {
        #line hidden
            return Template.Franchises.Getter(this); }
        #line 4 "ViewModels\CorporationPage.json"
        set {
        #line hidden
            Template.Franchises.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__NewFranchiseName__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String NewFranchiseName {
    #line 5 "ViewModels\CorporationPage.json"
        get {
        #line hidden
            return Template.NewFranchiseName.Getter(this); }
        #line 5 "ViewModels\CorporationPage.json"
        set {
        #line hidden
            Template.NewFranchiseName.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__SaveCorporationTrigger__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 SaveCorporationTrigger {
    #line 6 "ViewModels\CorporationPage.json"
        get {
        #line hidden
            return Template.SaveCorporationTrigger.Getter(this); }
        #line 6 "ViewModels\CorporationPage.json"
        set {
        #line hidden
            Template.SaveCorporationTrigger.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__FranchiseSaveTrigger__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 FranchiseSaveTrigger {
    #line 7 "ViewModels\CorporationPage.json"
        get {
        #line hidden
            return Template.FranchiseSaveTrigger.Getter(this); }
        #line 7 "ViewModels\CorporationPage.json"
        set {
        #line hidden
            Template.FranchiseSaveTrigger.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__Corporat__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Name : Input<__Corporat__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class NewFranchiseName : Input<__Corporat__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class SaveCorporationTrigger : Input<__Corporat__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class FranchiseSaveTrigger : Input<__Corporat__, __TLong__, long> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
