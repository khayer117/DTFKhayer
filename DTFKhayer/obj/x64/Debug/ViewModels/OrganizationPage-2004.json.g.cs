// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "ViewModels\OrganizationPage.json"
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
using __Organiza1__ = global::DTFKhayer.OrganizationPage.JsonByExample;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __OrSaveOrga__ = global::DTFKhayer.OrganizationPage.Input.SaveOrganizationTrigger;
using __OrName__ = global::DTFKhayer.OrganizationPage.Input.Name;
using __OrHtml__ = global::DTFKhayer.OrganizationPage.Input.Html;
using __Organiza2__ = global::DTFKhayer.OrganizationPage.Input;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __TString__ = global::Starcounter.Templates.TString;
using __OrSchema__ = global::DTFKhayer.OrganizationPage.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __Organiza__ = global::DTFKhayer.OrganizationPage;
using __TLong__ = global::Starcounter.Templates.TLong;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class OrganizationPage_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class OrganizationPage : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __OrSchema__ DefaultTemplate = new __OrSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public OrganizationPage() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public OrganizationPage(__OrSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __OrSchema__ Template { get { return (__OrSchema__)base.Template; } set { base.Template = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__Organiza__);
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/DTFKhayer/viewmodels/OrganizationPage.html";
                Html.SetCustomAccessors((_p_) => { return ((__Organiza__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__Organiza__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Name = Add<__TString__>("Name$");
                Name.DefaultValue = "";
                Name.Editable = true;
                Name.SetCustomAccessors((_p_) => { return ((__Organiza__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__Organiza__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                SaveOrganizationTrigger = Add<__TLong__>("SaveOrganizationTrigger$");
                SaveOrganizationTrigger.DefaultValue = 0L;
                SaveOrganizationTrigger.Editable = true;
                SaveOrganizationTrigger.SetCustomAccessors((_p_) => { return ((__Organiza__)_p_).__bf__SaveOrganizationTrigger__; }, (_p_, _v_) => { ((__Organiza__)_p_).__bf__SaveOrganizationTrigger__ = (System.Int64)_v_; }, false);
                SaveOrganizationTrigger.AddHandler((Json pup, Property<Int64> prop, Int64 value) => { return (new Input.SaveOrganizationTrigger() { App = (OrganizationPage)pup, Template = (TLong)prop, Value = value }); }, (Json pup, Starcounter.Input<Int64> input) => { ((OrganizationPage)pup).Handle((Input.SaveOrganizationTrigger)input); });
            }
            public override object CreateInstance(s.Json parent) { return new __Organiza__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ Name;
            public __TLong__ SaveOrganizationTrigger;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "ViewModels\OrganizationPage.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "ViewModels\OrganizationPage.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Name__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Name {
    #line 3 "ViewModels\OrganizationPage.json"
        get {
        #line hidden
            return Template.Name.Getter(this); }
        #line 3 "ViewModels\OrganizationPage.json"
        set {
        #line hidden
            Template.Name.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__SaveOrganizationTrigger__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 SaveOrganizationTrigger {
    #line 4 "ViewModels\OrganizationPage.json"
        get {
        #line hidden
            return Template.SaveOrganizationTrigger.Getter(this); }
        #line 4 "ViewModels\OrganizationPage.json"
        set {
        #line hidden
            Template.SaveOrganizationTrigger.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__Organiza__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Name : Input<__Organiza__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class SaveOrganizationTrigger : Input<__Organiza__, __TLong__, long> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
