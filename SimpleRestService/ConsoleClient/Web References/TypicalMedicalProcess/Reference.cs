﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.34014.
// 
#pragma warning disable 1591

namespace ConsoleClient.TypicalMedicalProcess {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="BasicHttpBinding_ISoapService", Namespace="http://tempuri.org/")]
    public partial class BasicHttpBinding_ISoapService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback GetDataOperationCompleted;
        
        private System.Threading.SendOrPostCallback CreateNewAmbulatoryPatientTicketOperationCompleted;
        
        private System.Threading.SendOrPostCallback PassMedicalExaminationOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public BasicHttpBinding_ISoapService() {
            this.Url = global::ConsoleClient.Properties.Settings.Default.ConsoleClient_TypicalMedicalProcess_SoapService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event GetDataCompletedEventHandler GetDataCompleted;
        
        /// <remarks/>
        public event CreateNewAmbulatoryPatientTicketCompletedEventHandler CreateNewAmbulatoryPatientTicketCompleted;
        
        /// <remarks/>
        public event PassMedicalExaminationCompletedEventHandler PassMedicalExaminationCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ISoapService/GetData", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string GetData([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string input) {
            object[] results = this.Invoke("GetData", new object[] {
                        input});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void GetDataAsync(string input) {
            this.GetDataAsync(input, null);
        }
        
        /// <remarks/>
        public void GetDataAsync(string input, object userState) {
            if ((this.GetDataOperationCompleted == null)) {
                this.GetDataOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetDataOperationCompleted);
            }
            this.InvokeAsync("GetData", new object[] {
                        input}, this.GetDataOperationCompleted, userState);
        }
        
        private void OnGetDataOperationCompleted(object arg) {
            if ((this.GetDataCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetDataCompleted(this, new GetDataCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ISoapService/CreateNewAmbulatoryPatientTicket", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string CreateNewAmbulatoryPatientTicket([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string input) {
            object[] results = this.Invoke("CreateNewAmbulatoryPatientTicket", new object[] {
                        input});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void CreateNewAmbulatoryPatientTicketAsync(string input) {
            this.CreateNewAmbulatoryPatientTicketAsync(input, null);
        }
        
        /// <remarks/>
        public void CreateNewAmbulatoryPatientTicketAsync(string input, object userState) {
            if ((this.CreateNewAmbulatoryPatientTicketOperationCompleted == null)) {
                this.CreateNewAmbulatoryPatientTicketOperationCompleted = new System.Threading.SendOrPostCallback(this.OnCreateNewAmbulatoryPatientTicketOperationCompleted);
            }
            this.InvokeAsync("CreateNewAmbulatoryPatientTicket", new object[] {
                        input}, this.CreateNewAmbulatoryPatientTicketOperationCompleted, userState);
        }
        
        private void OnCreateNewAmbulatoryPatientTicketOperationCompleted(object arg) {
            if ((this.CreateNewAmbulatoryPatientTicketCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.CreateNewAmbulatoryPatientTicketCompleted(this, new CreateNewAmbulatoryPatientTicketCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ISoapService/PassMedicalExamination", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        [return: System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string PassMedicalExamination([System.Xml.Serialization.XmlElementAttribute(IsNullable=true)] string input) {
            object[] results = this.Invoke("PassMedicalExamination", new object[] {
                        input});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void PassMedicalExaminationAsync(string input) {
            this.PassMedicalExaminationAsync(input, null);
        }
        
        /// <remarks/>
        public void PassMedicalExaminationAsync(string input, object userState) {
            if ((this.PassMedicalExaminationOperationCompleted == null)) {
                this.PassMedicalExaminationOperationCompleted = new System.Threading.SendOrPostCallback(this.OnPassMedicalExaminationOperationCompleted);
            }
            this.InvokeAsync("PassMedicalExamination", new object[] {
                        input}, this.PassMedicalExaminationOperationCompleted, userState);
        }
        
        private void OnPassMedicalExaminationOperationCompleted(object arg) {
            if ((this.PassMedicalExaminationCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.PassMedicalExaminationCompleted(this, new PassMedicalExaminationCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="TypicalMedicalProcessBinding", Namespace="http://TypicalMedicalProcess.com")]
    public partial class TypicalMedicalProcessBinding : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback processOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public TypicalMedicalProcessBinding() {
            this.Url = global::ConsoleClient.Properties.Settings.Default.ConsoleClient_TypicalMedicalProcess_TypicalMedicalProcessService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event processCompletedEventHandler processCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://TypicalMedicalProcess.com/process", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Bare)]
        [return: System.Xml.Serialization.XmlElementAttribute("TypicalMedicalProcessResponse", Namespace="http://TypicalMedicalProcess.com")]
        public TypicalMedicalProcessResponse process([System.Xml.Serialization.XmlElementAttribute(Namespace="http://TypicalMedicalProcess.com")] TypicalMedicalProcessRequest TypicalMedicalProcessRequest) {
            object[] results = this.Invoke("process", new object[] {
                        TypicalMedicalProcessRequest});
            return ((TypicalMedicalProcessResponse)(results[0]));
        }
        
        /// <remarks/>
        public void processAsync(TypicalMedicalProcessRequest TypicalMedicalProcessRequest) {
            this.processAsync(TypicalMedicalProcessRequest, null);
        }
        
        /// <remarks/>
        public void processAsync(TypicalMedicalProcessRequest TypicalMedicalProcessRequest, object userState) {
            if ((this.processOperationCompleted == null)) {
                this.processOperationCompleted = new System.Threading.SendOrPostCallback(this.OnprocessOperationCompleted);
            }
            this.InvokeAsync("process", new object[] {
                        TypicalMedicalProcessRequest}, this.processOperationCompleted, userState);
        }
        
        private void OnprocessOperationCompleted(object arg) {
            if ((this.processCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.processCompleted(this, new processCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://TypicalMedicalProcess.com")]
    public partial class TypicalMedicalProcessRequest {
        
        private string inputField;
        
        /// <remarks/>
        public string input {
            get {
                return this.inputField;
            }
            set {
                this.inputField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.33440")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://TypicalMedicalProcess.com")]
    public partial class TypicalMedicalProcessResponse {
        
        private string resultField;
        
        /// <remarks/>
        public string result {
            get {
                return this.resultField;
            }
            set {
                this.resultField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void GetDataCompletedEventHandler(object sender, GetDataCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetDataCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetDataCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void CreateNewAmbulatoryPatientTicketCompletedEventHandler(object sender, CreateNewAmbulatoryPatientTicketCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class CreateNewAmbulatoryPatientTicketCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal CreateNewAmbulatoryPatientTicketCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void PassMedicalExaminationCompletedEventHandler(object sender, PassMedicalExaminationCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class PassMedicalExaminationCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal PassMedicalExaminationCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    public delegate void processCompletedEventHandler(object sender, processCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.0.30319.33440")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class processCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal processCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public TypicalMedicalProcessResponse Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((TypicalMedicalProcessResponse)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591