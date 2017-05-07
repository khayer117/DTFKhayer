// This is a system generated file (G2). It reflects the Starcounter App Template defined in the file "ViewModels\FranchiseDetails.json"
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

namespace DTFKhayer.ViewModels {
using __Franchis__ = global::DTFKhayer.ViewModels.FranchiseDetails;
using __Json__ = global::Starcounter.Json;
using __TObject__ = global::Starcounter.Templates.TObject;
using __Json1__ = global::Starcounter.Json.JsonByExample;
using __FrSchema__ = global::DTFKhayer.ViewModels.FranchiseDetails.JsonByExample.Schema;
using __Franchis1__ = global::DTFKhayer.ViewModels.FranchiseDetails.JsonByExample;
using __Franchis2__ = global::DTFKhayer.ViewModels.FranchiseDetails.Input;
using s = Starcounter;
using st = Starcounter.Templates;
using _ScTemplate_ = Starcounter.Templates.Template;
using _GEN1_ = System.Diagnostics.DebuggerNonUserCodeAttribute;
using _GEN2_ = System.CodeDom.Compiler.GeneratedCodeAttribute;

#line hidden
public partial class FranchiseDetails : __Json__ {
    #line hidden
    [_GEN2_("Starcounter","2.0")]
    public static __FrSchema__ DefaultTemplate = new __FrSchema__();
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public FranchiseDetails() { }
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public FranchiseDetails(__FrSchema__ template) { Template = template; }
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
            }
            public override object CreateInstance(s.Json parent) { return new __Franchis__(this) { Parent = parent }; }
        }
        #line default
    }
    #line default
    
    #line hidden
    [_GEN1_][_GEN2_("Starcounter","2.0")]
    public static class Input {
    }
    #line default
}
#line default

#line hidden
[_GEN1_][_GEN2_("Starcounter","2.0")]
public class FranchiseDetails_json : s::TemplateAttribute {
}
#line default
}
#pragma warning restore 1591
#pragma warning restore 0108
