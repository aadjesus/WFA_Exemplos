﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace WFA_Exemplos.testeSoapHeader {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="LogGlobusMaisWSSoap", Namespace="http://bgmrodotec.com.br/fglobus/controle")]
    public partial class LogGlobusMaisWS : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private AutenticacaoWebService autenticacaoWebServiceValueField;
        
        private System.Threading.SendOrPostCallback GravarLogOperationCompleted;
        
        private System.Threading.SendOrPostCallback GravarLogBasicoOperationCompleted;
        
        private System.Threading.SendOrPostCallback RetornarLogOperationCompleted;
        
        private System.Threading.SendOrPostCallback Teste_1OperationCompleted;
        
        private System.Threading.SendOrPostCallback Teste_2OperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public LogGlobusMaisWS() {
            this.Url = global::WFA_Exemplos.Properties.Settings.Default.WFA_Exemplos_testeSoapHeader_LogGlobusMaisWS;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public AutenticacaoWebService AutenticacaoWebServiceValue {
            get {
                return this.autenticacaoWebServiceValueField;
            }
            set {
                this.autenticacaoWebServiceValueField = value;
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
        public event GravarLogCompletedEventHandler GravarLogCompleted;
        
        /// <remarks/>
        public event GravarLogBasicoCompletedEventHandler GravarLogBasicoCompleted;
        
        /// <remarks/>
        public event RetornarLogCompletedEventHandler RetornarLogCompleted;
        
        /// <remarks/>
        public event Teste_1CompletedEventHandler Teste_1Completed;
        
        /// <remarks/>
        public event Teste_2CompletedEventHandler Teste_2Completed;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AutenticacaoWebServiceValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://bgmrodotec.com.br/fglobus/controle/GravarLog", RequestNamespace="http://bgmrodotec.com.br/fglobus/controle", ResponseNamespace="http://bgmrodotec.com.br/fglobus/controle", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public double GravarLog(LogVO logVO) {
            object[] results = this.Invoke("GravarLog", new object[] {
                        logVO});
            return ((double)(results[0]));
        }
        
        /// <remarks/>
        public void GravarLogAsync(LogVO logVO) {
            this.GravarLogAsync(logVO, null);
        }
        
        /// <remarks/>
        public void GravarLogAsync(LogVO logVO, object userState) {
            if ((this.GravarLogOperationCompleted == null)) {
                this.GravarLogOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGravarLogOperationCompleted);
            }
            this.InvokeAsync("GravarLog", new object[] {
                        logVO}, this.GravarLogOperationCompleted, userState);
        }
        
        private void OnGravarLogOperationCompleted(object arg) {
            if ((this.GravarLogCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GravarLogCompleted(this, new GravarLogCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AutenticacaoWebServiceValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://bgmrodotec.com.br/fglobus/controle/GravarLogBasico", RequestNamespace="http://bgmrodotec.com.br/fglobus/controle", ResponseNamespace="http://bgmrodotec.com.br/fglobus/controle", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public double GravarLogBasico(string usuario, string sistema, string textoLog) {
            object[] results = this.Invoke("GravarLogBasico", new object[] {
                        usuario,
                        sistema,
                        textoLog});
            return ((double)(results[0]));
        }
        
        /// <remarks/>
        public void GravarLogBasicoAsync(string usuario, string sistema, string textoLog) {
            this.GravarLogBasicoAsync(usuario, sistema, textoLog, null);
        }
        
        /// <remarks/>
        public void GravarLogBasicoAsync(string usuario, string sistema, string textoLog, object userState) {
            if ((this.GravarLogBasicoOperationCompleted == null)) {
                this.GravarLogBasicoOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGravarLogBasicoOperationCompleted);
            }
            this.InvokeAsync("GravarLogBasico", new object[] {
                        usuario,
                        sistema,
                        textoLog}, this.GravarLogBasicoOperationCompleted, userState);
        }
        
        private void OnGravarLogBasicoOperationCompleted(object arg) {
            if ((this.GravarLogBasicoCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GravarLogBasicoCompleted(this, new GravarLogBasicoCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AutenticacaoWebServiceValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://bgmrodotec.com.br/fglobus/controle/RetornarLog", RequestNamespace="http://bgmrodotec.com.br/fglobus/controle", ResponseNamespace="http://bgmrodotec.com.br/fglobus/controle", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public LogVO[] RetornarLog(System.DateTime datatInicial, System.DateTime datatFinal, int[] listaTipoBotao, string[] listaItemDeMenu) {
            object[] results = this.Invoke("RetornarLog", new object[] {
                        datatInicial,
                        datatFinal,
                        listaTipoBotao,
                        listaItemDeMenu});
            return ((LogVO[])(results[0]));
        }
        
        /// <remarks/>
        public void RetornarLogAsync(System.DateTime datatInicial, System.DateTime datatFinal, int[] listaTipoBotao, string[] listaItemDeMenu) {
            this.RetornarLogAsync(datatInicial, datatFinal, listaTipoBotao, listaItemDeMenu, null);
        }
        
        /// <remarks/>
        public void RetornarLogAsync(System.DateTime datatInicial, System.DateTime datatFinal, int[] listaTipoBotao, string[] listaItemDeMenu, object userState) {
            if ((this.RetornarLogOperationCompleted == null)) {
                this.RetornarLogOperationCompleted = new System.Threading.SendOrPostCallback(this.OnRetornarLogOperationCompleted);
            }
            this.InvokeAsync("RetornarLog", new object[] {
                        datatInicial,
                        datatFinal,
                        listaTipoBotao,
                        listaItemDeMenu}, this.RetornarLogOperationCompleted, userState);
        }
        
        private void OnRetornarLogOperationCompleted(object arg) {
            if ((this.RetornarLogCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.RetornarLogCompleted(this, new RetornarLogCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapHeaderAttribute("AutenticacaoWebServiceValue")]
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://bgmrodotec.com.br/fglobus/controle/Teste_1", RequestNamespace="http://bgmrodotec.com.br/fglobus/controle", ResponseNamespace="http://bgmrodotec.com.br/fglobus/controle", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string Teste_1() {
            object[] results = this.Invoke("Teste_1", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void Teste_1Async() {
            this.Teste_1Async(null);
        }
        
        /// <remarks/>
        public void Teste_1Async(object userState) {
            if ((this.Teste_1OperationCompleted == null)) {
                this.Teste_1OperationCompleted = new System.Threading.SendOrPostCallback(this.OnTeste_1OperationCompleted);
            }
            this.InvokeAsync("Teste_1", new object[0], this.Teste_1OperationCompleted, userState);
        }
        
        private void OnTeste_1OperationCompleted(object arg) {
            if ((this.Teste_1Completed != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.Teste_1Completed(this, new Teste_1CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://bgmrodotec.com.br/fglobus/controle/Teste_2", RequestNamespace="http://bgmrodotec.com.br/fglobus/controle", ResponseNamespace="http://bgmrodotec.com.br/fglobus/controle", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string Teste_2() {
            object[] results = this.Invoke("Teste_2", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void Teste_2Async() {
            this.Teste_2Async(null);
        }
        
        /// <remarks/>
        public void Teste_2Async(object userState) {
            if ((this.Teste_2OperationCompleted == null)) {
                this.Teste_2OperationCompleted = new System.Threading.SendOrPostCallback(this.OnTeste_2OperationCompleted);
            }
            this.InvokeAsync("Teste_2", new object[0], this.Teste_2OperationCompleted, userState);
        }
        
        private void OnTeste_2OperationCompleted(object arg) {
            if ((this.Teste_2Completed != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.Teste_2Completed(this, new Teste_2CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.79.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://bgmrodotec.com.br/fglobus/controle")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://bgmrodotec.com.br/fglobus/controle", IsNullable=false)]
    public partial class AutenticacaoWebService : System.Web.Services.Protocols.SoapHeader {
        
        private int tokenField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        /// <remarks/>
        public int Token {
            get {
                return this.tokenField;
            }
            set {
                this.tokenField = value;
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.79.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://bgmrodotec.com.br/fglobus/controle")]
    public partial class LogSACVO {
        
        private double iDLogField;
        
        private string codigoFuncionarioField;
        
        private string usuarioSOField;
        
        private string motivoField;
        
        /// <remarks/>
        public double IDLog {
            get {
                return this.iDLogField;
            }
            set {
                this.iDLogField = value;
            }
        }
        
        /// <remarks/>
        public string CodigoFuncionario {
            get {
                return this.codigoFuncionarioField;
            }
            set {
                this.codigoFuncionarioField = value;
            }
        }
        
        /// <remarks/>
        public string UsuarioSO {
            get {
                return this.usuarioSOField;
            }
            set {
                this.usuarioSOField = value;
            }
        }
        
        /// <remarks/>
        public string Motivo {
            get {
                return this.motivoField;
            }
            set {
                this.motivoField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.79.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://bgmrodotec.com.br/fglobus/controle")]
    public partial class LogCampoVO {
        
        private string nomeField;
        
        private string tipoField;
        
        private string mascaraField;
        
        private string tituloField;
        
        private string valorField;
        
        /// <remarks/>
        public string Nome {
            get {
                return this.nomeField;
            }
            set {
                this.nomeField = value;
            }
        }
        
        /// <remarks/>
        public string Tipo {
            get {
                return this.tipoField;
            }
            set {
                this.tipoField = value;
            }
        }
        
        /// <remarks/>
        public string Mascara {
            get {
                return this.mascaraField;
            }
            set {
                this.mascaraField = value;
            }
        }
        
        /// <remarks/>
        public string Titulo {
            get {
                return this.tituloField;
            }
            set {
                this.tituloField = value;
            }
        }
        
        /// <remarks/>
        public string Valor {
            get {
                return this.valorField;
            }
            set {
                this.valorField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.6.79.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://bgmrodotec.com.br/fglobus/controle")]
    public partial class LogVO {
        
        private double idField;
        
        private string sistemaField;
        
        private string usuarioField;
        
        private System.DateTime dataField;
        
        private int tipoBotaoField;
        
        private string itemDeMenuField;
        
        private string nomeAssemblyField;
        
        private string tituloCamposChaveField;
        
        private string valorCamposChaveField;
        
        private string complementoField;
        
        private LogCampoVO[] listaCamposField;
        
        private LogSACVO usuarioSACField;
        
        /// <remarks/>
        public double ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
        
        /// <remarks/>
        public string Sistema {
            get {
                return this.sistemaField;
            }
            set {
                this.sistemaField = value;
            }
        }
        
        /// <remarks/>
        public string Usuario {
            get {
                return this.usuarioField;
            }
            set {
                this.usuarioField = value;
            }
        }
        
        /// <remarks/>
        public System.DateTime Data {
            get {
                return this.dataField;
            }
            set {
                this.dataField = value;
            }
        }
        
        /// <remarks/>
        public int TipoBotao {
            get {
                return this.tipoBotaoField;
            }
            set {
                this.tipoBotaoField = value;
            }
        }
        
        /// <remarks/>
        public string ItemDeMenu {
            get {
                return this.itemDeMenuField;
            }
            set {
                this.itemDeMenuField = value;
            }
        }
        
        /// <remarks/>
        public string NomeAssembly {
            get {
                return this.nomeAssemblyField;
            }
            set {
                this.nomeAssemblyField = value;
            }
        }
        
        /// <remarks/>
        public string TituloCamposChave {
            get {
                return this.tituloCamposChaveField;
            }
            set {
                this.tituloCamposChaveField = value;
            }
        }
        
        /// <remarks/>
        public string ValorCamposChave {
            get {
                return this.valorCamposChaveField;
            }
            set {
                this.valorCamposChaveField = value;
            }
        }
        
        /// <remarks/>
        public string Complemento {
            get {
                return this.complementoField;
            }
            set {
                this.complementoField = value;
            }
        }
        
        /// <remarks/>
        public LogCampoVO[] ListaCampos {
            get {
                return this.listaCamposField;
            }
            set {
                this.listaCamposField = value;
            }
        }
        
        /// <remarks/>
        public LogSACVO UsuarioSAC {
            get {
                return this.usuarioSACField;
            }
            set {
                this.usuarioSACField = value;
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    public delegate void GravarLogCompletedEventHandler(object sender, GravarLogCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GravarLogCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GravarLogCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public double Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((double)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    public delegate void GravarLogBasicoCompletedEventHandler(object sender, GravarLogBasicoCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GravarLogBasicoCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GravarLogBasicoCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public double Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((double)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    public delegate void RetornarLogCompletedEventHandler(object sender, RetornarLogCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class RetornarLogCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal RetornarLogCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public LogVO[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((LogVO[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    public delegate void Teste_1CompletedEventHandler(object sender, Teste_1CompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Teste_1CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal Teste_1CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    public delegate void Teste_2CompletedEventHandler(object sender, Teste_2CompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.79.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class Teste_2CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal Teste_2CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
}

#pragma warning restore 1591