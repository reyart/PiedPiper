﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ZpOptimizerUI {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    public sealed partial class Settings1 : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings1 defaultInstance = ((Settings1)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings1())));
        
        public static Settings1 Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("G:\\steam\\steamapps\\common")]
        public string defaultFolder {
            get {
                return ((string)(this["defaultFolder"]));
            }
            set {
                this["defaultFolder"] = value;
            }
        }
        
        [global::System.Configuration.UserScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute(@"<?xml version=""1.0"" encoding=""utf-16""?>
<ArrayOfString xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"" xmlns:xsd=""http://www.w3.org/2001/XMLSchema"">
  <string>C:\Program Files (x86)\Steam\Steamapps\common</string>
  <string>C:\Program Files (x86)\Ubisoft\Ubisoft Game Launcher\games</string>
  <string>C:\Program Files (x86)\Origin Games</string>
  <string>C:\Program Files (x86)\GalaxyClient\Games</string>
</ArrayOfString>")]
        public global::System.Collections.Specialized.StringCollection locationList {
            get {
                return ((global::System.Collections.Specialized.StringCollection)(this["locationList"]));
            }
            set {
                this["locationList"] = value;
            }
        }
    }
}
