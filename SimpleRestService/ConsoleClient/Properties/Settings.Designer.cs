﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleClient.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "12.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://localhost:28387/SoapService.svc")]
        public string ConsoleClient_SoapInvokerV2_SoapService {
            get {
                return ((string)(this["ConsoleClient_SoapInvokerV2_SoapService"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://localhost:8080/ode/processes/Caller")]
        public string ConsoleClient_SoapInvokerV2_CallerService {
            get {
                return ((string)(this["ConsoleClient_SoapInvokerV2_CallerService"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://localhost:8080/ode/processes/ProcessManagement.ProcessManagementPort/")]
        public string ConsoleClient_ProcessManagement_ProcessManagement {
            get {
                return ((string)(this["ConsoleClient_ProcessManagement_ProcessManagement"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://localhost:8080//LengthyProcess.LengthyProcessPort/")]
        public string ConsoleClient_LengthyProcess_LengthyProcess {
            get {
                return ((string)(this["ConsoleClient_LengthyProcess_LengthyProcess"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.SpecialSettingAttribute(global::System.Configuration.SpecialSetting.WebServiceUrl)]
        [global::System.Configuration.DefaultSettingValueAttribute("http://localhost:28387/SoapService.svc")]
        public string ConsoleClient_TypicalMedicalProcess_SoapService {
            get {
                return ((string)(this["ConsoleClient_TypicalMedicalProcess_SoapService"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("http://localhost:8080/ode/processes/TypicalMedicalProcess")]
        public string ConsoleClient_TypicalMedicalProcess_TypicalMedicalProcessService {
            get {
                return ((string)(this["ConsoleClient_TypicalMedicalProcess_TypicalMedicalProcessService"]));
            }
        }
    }
}