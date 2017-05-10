// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "ViewModels\FranchiseListPage.json"
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
using DTFKhayer.Services;
using DTFKhayerEntity;
using Starcounter.XSON.Interfaces;
#pragma warning disable 0108
#pragma warning disable 1591

namespace DTFKhayer {
using __Franchis2__ = global::DTFKhayer.FranchiseListPage.Input;
using _ScTemplate_ = Starcounter.Templates.Template;
using st = Starcounter.Templates;
using s = Starcounter;
using __FrTrend__ = global::DTFKhayer.FranchiseListPage.Input.Trend;
using __FrAverageC__ = global::DTFKhayer.FranchiseListPage.Input.AverageCommission;
using __FrTotalCom__ = global::DTFKhayer.FranchiseListPage.Input.TotalCommission;
using __FrTotalHom__ = global::DTFKhayer.FranchiseListPage.Input.TotalHomeSold;
using __FrKey__ = global::DTFKhayer.FranchiseListPage.Input.Key;
using __FrName__ = global::DTFKhayer.FranchiseListPage.Input.Name;
using __FrHtml__ = global::DTFKhayer.FranchiseListPage.Input.Html;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;
using __Franchis1__ = global::DTFKhayer.FranchiseListPage.JsonByExample;
using __TDecimal__ = global::Starcounter.Templates.TDecimal;
using __TLong__ = global::Starcounter.Templates.TLong;
using __TString__ = global::Starcounter.Templates.TString;
using __FrSchema__ = global::DTFKhayer.FranchiseListPage.JsonByExample.Schema;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json__ = global::Starcounter.Json;
using __Franchis__ = global::DTFKhayer.FranchiseListPage;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class FranchiseListPage_json : s::TemplateAttribute {
}
#line default

#line hidden
public partial class FranchiseListPage : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __FrSchema__ DefaultTemplate = new __FrSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public FranchiseListPage() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public FranchiseListPage(__FrSchema__ template) { Template = template; }
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
                Html.DefaultValue = "/DTFKhayer/viewmodels/FranchiseListPage.html";
                Html.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Html__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Html__ = (System.String)_v_; }, false);
                Name = Add<__TString__>("Name");
                Name.DefaultValue = "";
                Name.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Name__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Name__ = (System.String)_v_; }, false);
                Key = Add<__TString__>("Key");
                Key.DefaultValue = "";
                Key.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Key__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Key__ = (System.String)_v_; }, false);
                TotalHomeSold = Add<__TLong__>("TotalHomeSold");
                TotalHomeSold.DefaultValue = 0L;
                TotalHomeSold.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__TotalHomeSold__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__TotalHomeSold__ = (System.Int64)_v_; }, false);
                TotalCommission = Add<__TLong__>("TotalCommission");
                TotalCommission.DefaultValue = 0L;
                TotalCommission.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__TotalCommission__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__TotalCommission__ = (System.Int64)_v_; }, false);
                AverageCommission = Add<__TDecimal__>("AverageCommission");
                AverageCommission.DefaultValue = 0.0m;
                AverageCommission.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__AverageCommission__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__AverageCommission__ = (System.Decimal)_v_; }, false);
                Trend = Add<__TLong__>("Trend");
                Trend.DefaultValue = 0L;
                Trend.SetCustomAccessors((_p_) => { return ((__Franchis__)_p_).__bf__Trend__; }, (_p_, _v_) => { ((__Franchis__)_p_).__bf__Trend__ = (System.Int64)_v_; }, false);
            }
            public override object CreateInstance(s.Json parent) { return new __Franchis__(this) { Parent = parent }; }
            public __TString__ Html;
            public __TString__ Name;
            public __TString__ Key;
            public __TLong__ TotalHomeSold;
            public __TLong__ TotalCommission;
            public __TDecimal__ AverageCommission;
            public __TLong__ Trend;
        }
        #line default
    }
    #line default
    #line hidden
    private System.String __bf__Html__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Html {
    #line 2 "ViewModels\FranchiseListPage.json"
        get {
        #line hidden
            return Template.Html.Getter(this); }
        #line 2 "ViewModels\FranchiseListPage.json"
        set {
        #line hidden
            Template.Html.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Name__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Name {
    #line 3 "ViewModels\FranchiseListPage.json"
        get {
        #line hidden
            return Template.Name.Getter(this); }
        #line 3 "ViewModels\FranchiseListPage.json"
        set {
        #line hidden
            Template.Name.Setter(this, value); } }
        #line default
    #line hidden
    private System.String __bf__Key__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.String Key {
    #line 4 "ViewModels\FranchiseListPage.json"
        get {
        #line hidden
            return Template.Key.Getter(this); }
        #line 4 "ViewModels\FranchiseListPage.json"
        set {
        #line hidden
            Template.Key.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__TotalHomeSold__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 TotalHomeSold {
    #line 5 "ViewModels\FranchiseListPage.json"
        get {
        #line hidden
            return Template.TotalHomeSold.Getter(this); }
        #line 5 "ViewModels\FranchiseListPage.json"
        set {
        #line hidden
            Template.TotalHomeSold.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__TotalCommission__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 TotalCommission {
    #line 6 "ViewModels\FranchiseListPage.json"
        get {
        #line hidden
            return Template.TotalCommission.Getter(this); }
        #line 6 "ViewModels\FranchiseListPage.json"
        set {
        #line hidden
            Template.TotalCommission.Setter(this, value); } }
        #line default
    #line hidden
    private System.Decimal __bf__AverageCommission__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Decimal AverageCommission {
    #line 7 "ViewModels\FranchiseListPage.json"
        get {
        #line hidden
            return Template.AverageCommission.Getter(this); }
        #line 7 "ViewModels\FranchiseListPage.json"
        set {
        #line hidden
            Template.AverageCommission.Setter(this, value); } }
        #line default
    #line hidden
    private System.Int64 __bf__Trend__;
    #line default
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public System.Int64 Trend {
    #line 8 "ViewModels\FranchiseListPage.json"
        get {
        #line hidden
            return Template.Trend.Getter(this); }
        #line 8 "ViewModels\FranchiseListPage.json"
        set {
        #line hidden
            Template.Trend.Setter(this, value); } }
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
        public class Key : Input<__Franchis__, __TString__, string> {
        }
        #line default
        
        #line hidden
        public class TotalHomeSold : Input<__Franchis__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class TotalCommission : Input<__Franchis__, __TLong__, long> {
        }
        #line default
        
        #line hidden
        public class AverageCommission : Input<__Franchis__, __TDecimal__, Decimal> {
        }
        #line default
        
        #line hidden
        public class Trend : Input<__Franchis__, __TLong__, long> {
        }
        #line default
    }
    #line default
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
