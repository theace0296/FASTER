﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FASTER.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
    internal sealed partial class Options : global::System.Configuration.ApplicationSettingsBase {
        
        private static Options defaultInstance = ((Options)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Options())));
        
        public static Options Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string serverPath {
            get {
                return ((string)(this["serverPath"]));
            }
            set {
                this["serverPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string steamCMDPath {
            get {
                return ((string)(this["steamCMDPath"]));
            }
            set {
                this["steamCMDPath"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string steamUserName {
            get {
                return ((string)(this["steamUserName"]));
            }
            set {
                this["steamUserName"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("")]
        public string steamPassword {
            get {
                return ((string)(this["steamPassword"]));
            }
            set {
                this["steamPassword"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool firstRun {
            get {
                return ((bool)(this["firstRun"]));
            }
            set {
                this["firstRun"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool checkForAppUpdates {
            get {
                return ((bool)(this["checkForAppUpdates"]));
            }
            set {
                this["checkForAppUpdates"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool clearSettings {
            get {
                return ((bool)(this["clearSettings"]));
            }
            set {
                this["clearSettings"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::FASTER.Models.ServerCollection Servers {
            get {
                return ((global::FASTER.Models.ServerCollection)(this["Servers"]));
            }
            set {
                this["Servers"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool setupRun {
            get {
                return ((bool)(this["setupRun"]));
            }
            set {
                this["setupRun"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("Stable")]
        public string serverBranch {
            get {
                return ((string)(this["serverBranch"]));
            }
            set {
                this["serverBranch"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::FASTER.Models.SteamModCollection steamMods {
            get {
                return ((global::FASTER.Models.SteamModCollection)(this["steamMods"]));
            }
            set {
                this["steamMods"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Generic.List<FASTER.Models.LocalMod> localMods {
            get {
                return ((global::System.Collections.Generic.List<FASTER.Models.LocalMod>)(this["localMods"]));
            }
            set {
                this["localMods"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::System.Collections.Generic.List<System.String> localModFolders {
            get {
                return ((global::System.Collections.Generic.List<System.String>)(this["localModFolders"]));
            }
            set {
                this["localModFolders"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool excludeServerFolder {
            get {
                return ((bool)(this["excludeServerFolder"]));
            }
            set {
                this["excludeServerFolder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("True")]
        public bool checkForModUpdates {
            get {
                return ((bool)(this["checkForModUpdates"]));
            }
            set {
                this["checkForModUpdates"] = value;
            }
        }
    }
}
