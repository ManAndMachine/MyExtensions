﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DumpiLogicRules.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.10.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("MyExtensionsServer.Button_")]
        public string ButtonExtensionInternalName {
            get {
                return ((string)(this["ButtonExtensionInternalName"]));
            }
            set {
                this["ButtonExtensionInternalName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("\"C:\\program files (x86)\\xsd2code\\xsd2code.exe\" C:\\Users\\alex_\\OneDrive\\Documents\\" +
            "GitHub\\MyExtensions\\DumpiLogicRules\\iLogicRules.xsd DumpiLogicRulesExtension iLo" +
            "gicRules.cs /l CS /is+ /gbc- /ggbc+ /xa+")]
        public string XSDCodeInputStringiLogicRules {
            get {
                return ((string)(this["XSDCodeInputStringiLogicRules"]));
            }
            set {
                this["XSDCodeInputStringiLogicRules"] = value;
            }
        }
    }
}
