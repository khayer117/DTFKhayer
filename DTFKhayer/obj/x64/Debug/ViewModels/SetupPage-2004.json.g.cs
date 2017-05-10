// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "ViewModels\SetupPage.json"
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
using System.Linq;
using DTFKhayerEntity;
#pragma warning disable 0108
#pragma warning disable 1591

namespace DTFKhayer.ViewModels {
using __TArray__ = global::Starcounter.Templates.TArray<CorporationPage>;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __SeSaveCorp__ = global::DTFKhayer.ViewModels.SetupPage.Input.SaveCorporationTrigger;
using __SeIsShowCo__ = global::DTFKhayer.ViewModels.SetupPage.Input.IsShowCorporate;
using __SeName__ = global::DTFKhayer.ViewModels.SetupPage.Input.Name;
using __SeHtml__ = global::DTFKhayer.ViewModels.SetupPage.Input.Html;
using __SetupPag2__ = global::DTFKhayer.ViewModels.SetupPage.Input;
using __Arr__ = global::Starcounter.Arr<CorporationPage>;
using __SetupPag1__ = global::DTFKhayer.ViewModels.SetupPage.JsonByExample;
using __TLong__ = global::Starcounter.Templates.TLong;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __Corporat1__ = CorporationPage.JsonByExample;
using __CoSchema__ = CorporationPage.JsonByExample.Schema;
using __Corporat__ = CorporationPage;
using __TBool__ = global::Starcounter.Templates.TBool;
using __TString__ = global::Starcounter.Templates.TString;
using __SeSchema__ = global::DTFKhayer.ViewModels.SetupPage.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __SetupPag__ = global::DTFKhayer.ViewModels.SetupPage;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class SetupPage_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class SetupPage : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __SeSchema__ DefaultTemplate = new __SeSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public SetupPage() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public SetupPage(__SeSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __SeSchema__ Template { get { return (__SeSchema__)base.Template; } set { base.Template = value; } }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new Corporation Data { get { return (Corporation)base.Data; } set { base.Data = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__SetupPag__);
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/DTFKhayer/viewmodels/SetupPage.html";
                Html.SetCustomAccessors((_p_) => { return ((__SetupPag__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__SetupPag__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Name = Add<__TString__>("Name$");
                Name.DefaultValue = "";
                Name.Editable = true;
                Name.SetCustomAccessors((_p_) => { return ((__SetupPag__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__SetupPag__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                IsShowCorporate = Add<__TBool__>("IsShowCorporate");
                IsShowCorporate.DefaultValue = false;
                IsShowCorporate.SetCustomAccessors((_p_) => { return ((__SetupPag__)_p_).__bf__IsShowCorporate__; }, (_p_, _v_) => { ((__SetupPag__)_p_).__bf__IsShowCorporate__ = (System.Boolean)_v_; }, false);
                Corporates = Add<__TArray__>("Corporates");
                Corporates.SetCustomGetElementType((arr) => { return __Corporat__.DefaultTemplate;});
                Corporates.SetCustomAccessors((_p_) => { return ((__SetupPag__)_p_).__bf__Corporates__; }, (_p_, _v_) => { ((__SetupPag__)_p_).__bf__Corporates__ = (__Arr__)_v_; }, false);
                SaveCorporationTrigger = Add<__TLong__>("SaveCorporationTrigger$");
                SaveCorporationTrigger.DefaultValue = 0L;
                SaveCorporationTrigger.Editable = true;
                SaveCorporationTrigger.SetCustomAccessors((_p_) => { return ((__SetupPag__)_p_).__bf__SaveCorporationTrigger__; }, (_p_, _v_) => { ((__SetupPag__)_p_).__bf__SaveCorporationTrigger__ = (System.Int64)_v_; }, false);
                SaveCorporationTrigger.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.SaveCorporationTrigger() { App = (SetupPage)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((SetupPage)pup).Handle((Input.SaveCorporationTrigger)input); });
            }
            public override object CreateInstance(s.Json parent) { return new __SetupPag__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ Name;
            public __TBool__ IsShowCorporate;
            public __TArray__ Corporates;
            public __TLong__ SaveCorporationTrigger;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "ViewModels\SetupPage.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "ViewModels\SetupPage.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Name__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Name {
    #line 3 "ViewModels\SetupPage.json"
        get {
        #line hidden
            return Template.Name.Getter(this); }
        #line 3 "ViewModels\SetupPage.json"
        set {
        #line hidden
            Template.Name.Setter(this, value); } }
        #line default
    #line hidden
    private System.Boolean __bf__IsShowCorporate__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Boolean IsShowCorporate {
    #line 4 "ViewModels\SetupPage.json"
        get {
        #line hidden
            return Template.IsShowCorporate.Getter(this); }
        #line 4 "ViewModels\SetupPage.json"
        set {
        #line hidden
            Template.IsShowCorporate.Setter(this, value); } }
        #line default
    #line hidden
    private __Arr__ __bf__Corporates__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public __Arr__ Corporates {
    #line 5 "ViewModels\SetupPage.json"
        get {
        #line hidden
            return Template.Corporates.Getter(this); }
        #line 5 "ViewModels\SetupPage.json"
        set {
        #line hidden
            Template.Corporates.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__SaveCorporationTrigger__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 SaveCorporationTrigger {
    #line 6 "ViewModels\SetupPage.json"
        get {
        #line hidden
            return Template.SaveCorporationTrigger.Getter(this); }
        #line 6 "ViewModels\SetupPage.json"
        set {
        #line hidden
            Template.SaveCorporationTrigger.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__SetupPag__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Name : Input<__SetupPag__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class IsShowCorporate : Input<__SetupPag__, __TBool__, bool> {
        }
        #line default
        
        #line hidden
        public class SaveCorporationTrigger : Input<__SetupPag__, __TLong__, long> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
