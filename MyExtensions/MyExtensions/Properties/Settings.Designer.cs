﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyExtensions.Properties {
    
    
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
        [global::System.Configuration.DefaultSettingValueAttribute("GraitecExtensionsServer.Settings_")]
        public string SettingsButtonInternalName {
            get {
                return ((string)(this["SettingsButtonInternalName"]));
            }
            set {
                this["SettingsButtonInternalName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Application Configuration changes have been saved.")]
        public string AppSettingsChangesSavedMsg {
            get {
                return ((string)(this["AppSettingsChangesSavedMsg"]));
            }
            set {
                this["AppSettingsChangesSavedMsg"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Application Configuration")]
        public string AppSettingsConfigurationCaption {
            get {
                return ((string)(this["AppSettingsConfigurationCaption"]));
            }
            set {
                this["AppSettingsConfigurationCaption"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Application Configuration has been restored to default.")]
        public string AppSettingsDefaultsRestoredMsg {
            get {
                return ((string)(this["AppSettingsDefaultsRestoredMsg"]));
            }
            set {
                this["AppSettingsDefaultsRestoredMsg"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Failed to load the configuration file. Reason(")]
        public string AppSettingsFailedToLoadMsg {
            get {
                return ((string)(this["AppSettingsFailedToLoadMsg"]));
            }
            set {
                this["AppSettingsFailedToLoadMsg"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Failed to btnSave configuration. Reason(")]
        public string AppSettingsFailedToSaveMsg {
            get {
                return ((string)(this["AppSettingsFailedToSaveMsg"]));
            }
            set {
                this["AppSettingsFailedToSaveMsg"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Restore Application Configuration to default?")]
        public string AppSettingsRestoreDefaultsMsg {
            get {
                return ((string)(this["AppSettingsRestoreDefaultsMsg"]));
            }
            set {
                this["AppSettingsRestoreDefaultsMsg"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Save Application Configuration changes before closing?")]
        public string AppSettingsSaveChangesMsg {
            get {
                return ((string)(this["AppSettingsSaveChangesMsg"]));
            }
            set {
                this["AppSettingsSaveChangesMsg"] = value;
            }
        }
    }
}