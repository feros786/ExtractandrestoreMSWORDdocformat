﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TranslationAssistant.TranslationServices.Core.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "16.4.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("247be5c9de32425a9e82a8510ff6623c")]
        public string AzureKey {
            get {
                return ((string)(this["AzureKey"]));
            }
            set {
                this["AzureKey"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string CategoryID {
            get {
                return ((string)(this["CategoryID"]));
            }
            set {
                this["CategoryID"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Specialized.StringDictionary CustomLanguages {
            get {
                return ((global::System.Collections.Specialized.StringDictionary)(this["CustomLanguages"]));
            }
            set {
                this["CustomLanguages"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string AppId {
            get {
                return ((string)(this["AppId"]));
            }
            set {
                this["AppId"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UseAdvancedSettings {
            get {
                return ((bool)(this["UseAdvancedSettings"]));
            }
            set {
                this["UseAdvancedSettings"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string Adv_CategoryID {
            get {
                return ((string)(this["Adv_CategoryID"]));
            }
            set {
                this["Adv_CategoryID"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UseAzureGovernment {
            get {
                return ((bool)(this["UseAzureGovernment"]));
            }
            set {
                this["UseAzureGovernment"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool UseCustomEndpoint {
            get {
                return ((bool)(this["UseCustomEndpoint"]));
            }
            set {
                this["UseCustomEndpoint"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://localhost:5000")]
        public string CustomEndpointUrl {
            get {
                return ((string)(this["CustomEndpointUrl"]));
            }
            set {
                this["CustomEndpointUrl"] = value;
            }
        }
    }
}
