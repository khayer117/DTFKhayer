// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "ViewModels\SalesListPage.json"
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
using System.Runtime.CompilerServices;
using DTFKhayerEntity;
#pragma warning disable 0108
#pragma warning disable 1591

namespace DTFKhayer {
using __SalesLis2__ = global::DTFKhayer.SalesListPage.Input;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __SaAddress__ = global::DTFKhayer.SalesListPage.Input.Address;
using __SaCommissi__ = global::DTFKhayer.SalesListPage.Input.Commission;
using __SaPrice__ = global::DTFKhayer.SalesListPage.Input.Price;
using __SaSalesDat__ = global::DTFKhayer.SalesListPage.Input.SalesDate;
using __SaHtml__ = global::DTFKhayer.SalesListPage.Input.Html;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __TLong__ = global::Starcounter.Templates.TLong;
using __TString__ = global::Starcounter.Templates.TString;
using __SaSchema__ = global::DTFKhayer.SalesListPage.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __SalesLis__ = global::DTFKhayer.SalesListPage;
using __SalesLis1__ = global::DTFKhayer.SalesListPage.JsonByExample;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class SalesListPage_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class SalesListPage : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __SaSchema__ DefaultTemplate = new __SaSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public SalesListPage() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public SalesListPage(__SaSchema__ template) { Template = template; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    protected override _ScTemplate_ GetDefaultTemplate() { return DefaultTemplate; }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new __SaSchema__ Template { get { return (__SaSchema__)base.Template; } set { base.Template = value; } }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public new Sale Data { get { return (Sale)base.Data; } set { base.Data = value; } }
    public override bool IsCodegenerated { get { return true; } }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class JsonByExample {
        
        #line hidden
        public class Schema : __TObject__ {
            public Schema()
                : base() {
                InstanceType = typeof(__SalesLis__);
                Properties.ClearExposed();
                Html = Add<__TString__>("Html");
                Html.DefaultValue = "/DTFKhayer/viewmodels/SalesListPage.html";
                Html.SetCustomAccessors((_p_) => { return ((__SalesLis__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__SalesLis__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                SalesDate = Add<__TString__>("SalesDate");
                SalesDate.DefaultValue = "";
                SalesDate.SetCustomAccessors((_p_) => { return ((__SalesLis__)_p_).__bf__SalesDate__; }, (_p_, _v_) => { ((__SalesLis__)_p_).__bf__SalesDate__ = (System.String)_v_; }, false);
                Price = Add<__TLong__>("Price");
                Price.DefaultValue = 0L;
                Price.SetCustomAccessors((_p_) => { return ((__SalesLis__)_p_).__bf__Price__; }, (_p_, _v_) => { ((__SalesLis__)_p_).__bf__Price__ = (System.Int64)_v_; }, false);
                Commission = Add<__TLong__>("Commission");
                Commission.DefaultValue = 0L;
                Commission.SetCustomAccessors((_p_) => { return ((__SalesLis__)_p_).__bf__Commission__; }, (_p_, _v_) => { ((__SalesLis__)_p_).__bf__Commission__ = (System.Int64)_v_; }, false);
                Address = Add<__TString__>("Address");
                Address.DefaultValue = "";
                Address.SetCustomAccessors((_p_) => { return ((__SalesLis__)_p_).__bf__Address__; }, (_p_, _v_) => { ((__SalesLis__)_p_).__bf__Address__ = (System.String)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __SalesLis__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ SalesDate;
            public __TLong__ Price;
            public __TLong__ Commission;
            public __TString__ Address;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "ViewModels\SalesListPage.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "ViewModels\SalesListPage.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__SalesDate__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String SalesDate {
    #line 3 "ViewModels\SalesListPage.json"
        get {
        #line hidden
            return Template.SalesDate.Getter(this); }
        #line 3 "ViewModels\SalesListPage.json"
        set {
        #line hidden
            Template.SalesDate.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__Price__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 Price {
    #line 4 "ViewModels\SalesListPage.json"
        get {
        #line hidden
            return Template.Price.Getter(this); }
        #line 4 "ViewModels\SalesListPage.json"
        set {
        #line hidden
            Template.Price.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__Commission__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 Commission {
    #line 5 "ViewModels\SalesListPage.json"
        get {
        #line hidden
            return Template.Commission.Getter(this); }
        #line 5 "ViewModels\SalesListPage.json"
        set {
        #line hidden
            Template.Commission.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Address__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Address {
    #line 6 "ViewModels\SalesListPage.json"
        get {
        #line hidden
            return Template.Address.Getter(this); }
        #line 6 "ViewModels\SalesListPage.json"
        set {
        #line hidden
            Template.Address.Setter(this, value); } }
        #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
        
        #line hidden
        public class Html : Input<__SalesLis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class SalesDate : Input<__SalesLis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class Price : Input<__SalesLis__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class Commission : Input<__SalesLis__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class Address : Input<__SalesLis__, __TString__, string> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
