﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WSClient.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.WebService1Soap")]
    public interface WebService1Soap {
        
        // CODEGEN: Generating message contract since element name systemtimeResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/systemtime", ReplyAction="*")]
        WSClient.ServiceReference1.systemtimeResponse systemtime(WSClient.ServiceReference1.systemtimeRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/systemtime", ReplyAction="*")]
        System.Threading.Tasks.Task<WSClient.ServiceReference1.systemtimeResponse> systemtimeAsync(WSClient.ServiceReference1.systemtimeRequest request);
        
        // CODEGEN: Generating message contract since element name p from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/db_insert", ReplyAction="*")]
        WSClient.ServiceReference1.db_insertResponse db_insert(WSClient.ServiceReference1.db_insertRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/db_insert", ReplyAction="*")]
        System.Threading.Tasks.Task<WSClient.ServiceReference1.db_insertResponse> db_insertAsync(WSClient.ServiceReference1.db_insertRequest request);
        
        // CODEGEN: Generating message contract since element name className from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Get_ListStudentsClassName", ReplyAction="*")]
        WSClient.ServiceReference1.Get_ListStudentsClassNameResponse Get_ListStudentsClassName(WSClient.ServiceReference1.Get_ListStudentsClassNameRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Get_ListStudentsClassName", ReplyAction="*")]
        System.Threading.Tasks.Task<WSClient.ServiceReference1.Get_ListStudentsClassNameResponse> Get_ListStudentsClassNameAsync(WSClient.ServiceReference1.Get_ListStudentsClassNameRequest request);
        
        // CODEGEN: Generating message contract since element name className from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Get_ListStudentsCourseClassName", ReplyAction="*")]
        WSClient.ServiceReference1.Get_ListStudentsCourseClassNameResponse Get_ListStudentsCourseClassName(WSClient.ServiceReference1.Get_ListStudentsCourseClassNameRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Get_ListStudentsCourseClassName", ReplyAction="*")]
        System.Threading.Tasks.Task<WSClient.ServiceReference1.Get_ListStudentsCourseClassNameResponse> Get_ListStudentsCourseClassNameAsync(WSClient.ServiceReference1.Get_ListStudentsCourseClassNameRequest request);
        
        // CODEGEN: Generating message contract since element name semester from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Get_Top5Students", ReplyAction="*")]
        WSClient.ServiceReference1.Get_Top5StudentsResponse Get_Top5Students(WSClient.ServiceReference1.Get_Top5StudentsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Get_Top5Students", ReplyAction="*")]
        System.Threading.Tasks.Task<WSClient.ServiceReference1.Get_Top5StudentsResponse> Get_Top5StudentsAsync(WSClient.ServiceReference1.Get_Top5StudentsRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class systemtimeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="systemtime", Namespace="http://tempuri.org/", Order=0)]
        public WSClient.ServiceReference1.systemtimeRequestBody Body;
        
        public systemtimeRequest() {
        }
        
        public systemtimeRequest(WSClient.ServiceReference1.systemtimeRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class systemtimeRequestBody {
        
        public systemtimeRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class systemtimeResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="systemtimeResponse", Namespace="http://tempuri.org/", Order=0)]
        public WSClient.ServiceReference1.systemtimeResponseBody Body;
        
        public systemtimeResponse() {
        }
        
        public systemtimeResponse(WSClient.ServiceReference1.systemtimeResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class systemtimeResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string systemtimeResult;
        
        public systemtimeResponseBody() {
        }
        
        public systemtimeResponseBody(string systemtimeResult) {
            this.systemtimeResult = systemtimeResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class db_insertRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="db_insert", Namespace="http://tempuri.org/", Order=0)]
        public WSClient.ServiceReference1.db_insertRequestBody Body;
        
        public db_insertRequest() {
        }
        
        public db_insertRequest(WSClient.ServiceReference1.db_insertRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class db_insertRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string p;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public int q;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string s;
        
        public db_insertRequestBody() {
        }
        
        public db_insertRequestBody(string p, int q, string s) {
            this.p = p;
            this.q = q;
            this.s = s;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class db_insertResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="db_insertResponse", Namespace="http://tempuri.org/", Order=0)]
        public WSClient.ServiceReference1.db_insertResponseBody Body;
        
        public db_insertResponse() {
        }
        
        public db_insertResponse(WSClient.ServiceReference1.db_insertResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class db_insertResponseBody {
        
        public db_insertResponseBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Get_ListStudentsClassNameRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Get_ListStudentsClassName", Namespace="http://tempuri.org/", Order=0)]
        public WSClient.ServiceReference1.Get_ListStudentsClassNameRequestBody Body;
        
        public Get_ListStudentsClassNameRequest() {
        }
        
        public Get_ListStudentsClassNameRequest(WSClient.ServiceReference1.Get_ListStudentsClassNameRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class Get_ListStudentsClassNameRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string className;
        
        public Get_ListStudentsClassNameRequestBody() {
        }
        
        public Get_ListStudentsClassNameRequestBody(string className) {
            this.className = className;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Get_ListStudentsClassNameResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Get_ListStudentsClassNameResponse", Namespace="http://tempuri.org/", Order=0)]
        public WSClient.ServiceReference1.Get_ListStudentsClassNameResponseBody Body;
        
        public Get_ListStudentsClassNameResponse() {
        }
        
        public Get_ListStudentsClassNameResponse(WSClient.ServiceReference1.Get_ListStudentsClassNameResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class Get_ListStudentsClassNameResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Get_ListStudentsClassNameResult;
        
        public Get_ListStudentsClassNameResponseBody() {
        }
        
        public Get_ListStudentsClassNameResponseBody(string Get_ListStudentsClassNameResult) {
            this.Get_ListStudentsClassNameResult = Get_ListStudentsClassNameResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Get_ListStudentsCourseClassNameRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Get_ListStudentsCourseClassName", Namespace="http://tempuri.org/", Order=0)]
        public WSClient.ServiceReference1.Get_ListStudentsCourseClassNameRequestBody Body;
        
        public Get_ListStudentsCourseClassNameRequest() {
        }
        
        public Get_ListStudentsCourseClassNameRequest(WSClient.ServiceReference1.Get_ListStudentsCourseClassNameRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class Get_ListStudentsCourseClassNameRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string className;
        
        public Get_ListStudentsCourseClassNameRequestBody() {
        }
        
        public Get_ListStudentsCourseClassNameRequestBody(string className) {
            this.className = className;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Get_ListStudentsCourseClassNameResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Get_ListStudentsCourseClassNameResponse", Namespace="http://tempuri.org/", Order=0)]
        public WSClient.ServiceReference1.Get_ListStudentsCourseClassNameResponseBody Body;
        
        public Get_ListStudentsCourseClassNameResponse() {
        }
        
        public Get_ListStudentsCourseClassNameResponse(WSClient.ServiceReference1.Get_ListStudentsCourseClassNameResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class Get_ListStudentsCourseClassNameResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Get_ListStudentsCourseClassNameResult;
        
        public Get_ListStudentsCourseClassNameResponseBody() {
        }
        
        public Get_ListStudentsCourseClassNameResponseBody(string Get_ListStudentsCourseClassNameResult) {
            this.Get_ListStudentsCourseClassNameResult = Get_ListStudentsCourseClassNameResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Get_Top5StudentsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Get_Top5Students", Namespace="http://tempuri.org/", Order=0)]
        public WSClient.ServiceReference1.Get_Top5StudentsRequestBody Body;
        
        public Get_Top5StudentsRequest() {
        }
        
        public Get_Top5StudentsRequest(WSClient.ServiceReference1.Get_Top5StudentsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class Get_Top5StudentsRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string semester;
        
        public Get_Top5StudentsRequestBody() {
        }
        
        public Get_Top5StudentsRequestBody(string semester) {
            this.semester = semester;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class Get_Top5StudentsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Get_Top5StudentsResponse", Namespace="http://tempuri.org/", Order=0)]
        public WSClient.ServiceReference1.Get_Top5StudentsResponseBody Body;
        
        public Get_Top5StudentsResponse() {
        }
        
        public Get_Top5StudentsResponse(WSClient.ServiceReference1.Get_Top5StudentsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class Get_Top5StudentsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string Get_Top5StudentsResult;
        
        public Get_Top5StudentsResponseBody() {
        }
        
        public Get_Top5StudentsResponseBody(string Get_Top5StudentsResult) {
            this.Get_Top5StudentsResult = Get_Top5StudentsResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : WSClient.ServiceReference1.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<WSClient.ServiceReference1.WebService1Soap>, WSClient.ServiceReference1.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WSClient.ServiceReference1.systemtimeResponse WSClient.ServiceReference1.WebService1Soap.systemtime(WSClient.ServiceReference1.systemtimeRequest request) {
            return base.Channel.systemtime(request);
        }
        
        public string systemtime() {
            WSClient.ServiceReference1.systemtimeRequest inValue = new WSClient.ServiceReference1.systemtimeRequest();
            inValue.Body = new WSClient.ServiceReference1.systemtimeRequestBody();
            WSClient.ServiceReference1.systemtimeResponse retVal = ((WSClient.ServiceReference1.WebService1Soap)(this)).systemtime(inValue);
            return retVal.Body.systemtimeResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WSClient.ServiceReference1.systemtimeResponse> WSClient.ServiceReference1.WebService1Soap.systemtimeAsync(WSClient.ServiceReference1.systemtimeRequest request) {
            return base.Channel.systemtimeAsync(request);
        }
        
        public System.Threading.Tasks.Task<WSClient.ServiceReference1.systemtimeResponse> systemtimeAsync() {
            WSClient.ServiceReference1.systemtimeRequest inValue = new WSClient.ServiceReference1.systemtimeRequest();
            inValue.Body = new WSClient.ServiceReference1.systemtimeRequestBody();
            return ((WSClient.ServiceReference1.WebService1Soap)(this)).systemtimeAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WSClient.ServiceReference1.db_insertResponse WSClient.ServiceReference1.WebService1Soap.db_insert(WSClient.ServiceReference1.db_insertRequest request) {
            return base.Channel.db_insert(request);
        }
        
        public void db_insert(string p, int q, string s) {
            WSClient.ServiceReference1.db_insertRequest inValue = new WSClient.ServiceReference1.db_insertRequest();
            inValue.Body = new WSClient.ServiceReference1.db_insertRequestBody();
            inValue.Body.p = p;
            inValue.Body.q = q;
            inValue.Body.s = s;
            WSClient.ServiceReference1.db_insertResponse retVal = ((WSClient.ServiceReference1.WebService1Soap)(this)).db_insert(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WSClient.ServiceReference1.db_insertResponse> WSClient.ServiceReference1.WebService1Soap.db_insertAsync(WSClient.ServiceReference1.db_insertRequest request) {
            return base.Channel.db_insertAsync(request);
        }
        
        public System.Threading.Tasks.Task<WSClient.ServiceReference1.db_insertResponse> db_insertAsync(string p, int q, string s) {
            WSClient.ServiceReference1.db_insertRequest inValue = new WSClient.ServiceReference1.db_insertRequest();
            inValue.Body = new WSClient.ServiceReference1.db_insertRequestBody();
            inValue.Body.p = p;
            inValue.Body.q = q;
            inValue.Body.s = s;
            return ((WSClient.ServiceReference1.WebService1Soap)(this)).db_insertAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WSClient.ServiceReference1.Get_ListStudentsClassNameResponse WSClient.ServiceReference1.WebService1Soap.Get_ListStudentsClassName(WSClient.ServiceReference1.Get_ListStudentsClassNameRequest request) {
            return base.Channel.Get_ListStudentsClassName(request);
        }
        
        public string Get_ListStudentsClassName(string className) {
            WSClient.ServiceReference1.Get_ListStudentsClassNameRequest inValue = new WSClient.ServiceReference1.Get_ListStudentsClassNameRequest();
            inValue.Body = new WSClient.ServiceReference1.Get_ListStudentsClassNameRequestBody();
            inValue.Body.className = className;
            WSClient.ServiceReference1.Get_ListStudentsClassNameResponse retVal = ((WSClient.ServiceReference1.WebService1Soap)(this)).Get_ListStudentsClassName(inValue);
            return retVal.Body.Get_ListStudentsClassNameResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WSClient.ServiceReference1.Get_ListStudentsClassNameResponse> WSClient.ServiceReference1.WebService1Soap.Get_ListStudentsClassNameAsync(WSClient.ServiceReference1.Get_ListStudentsClassNameRequest request) {
            return base.Channel.Get_ListStudentsClassNameAsync(request);
        }
        
        public System.Threading.Tasks.Task<WSClient.ServiceReference1.Get_ListStudentsClassNameResponse> Get_ListStudentsClassNameAsync(string className) {
            WSClient.ServiceReference1.Get_ListStudentsClassNameRequest inValue = new WSClient.ServiceReference1.Get_ListStudentsClassNameRequest();
            inValue.Body = new WSClient.ServiceReference1.Get_ListStudentsClassNameRequestBody();
            inValue.Body.className = className;
            return ((WSClient.ServiceReference1.WebService1Soap)(this)).Get_ListStudentsClassNameAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WSClient.ServiceReference1.Get_ListStudentsCourseClassNameResponse WSClient.ServiceReference1.WebService1Soap.Get_ListStudentsCourseClassName(WSClient.ServiceReference1.Get_ListStudentsCourseClassNameRequest request) {
            return base.Channel.Get_ListStudentsCourseClassName(request);
        }
        
        public string Get_ListStudentsCourseClassName(string className) {
            WSClient.ServiceReference1.Get_ListStudentsCourseClassNameRequest inValue = new WSClient.ServiceReference1.Get_ListStudentsCourseClassNameRequest();
            inValue.Body = new WSClient.ServiceReference1.Get_ListStudentsCourseClassNameRequestBody();
            inValue.Body.className = className;
            WSClient.ServiceReference1.Get_ListStudentsCourseClassNameResponse retVal = ((WSClient.ServiceReference1.WebService1Soap)(this)).Get_ListStudentsCourseClassName(inValue);
            return retVal.Body.Get_ListStudentsCourseClassNameResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WSClient.ServiceReference1.Get_ListStudentsCourseClassNameResponse> WSClient.ServiceReference1.WebService1Soap.Get_ListStudentsCourseClassNameAsync(WSClient.ServiceReference1.Get_ListStudentsCourseClassNameRequest request) {
            return base.Channel.Get_ListStudentsCourseClassNameAsync(request);
        }
        
        public System.Threading.Tasks.Task<WSClient.ServiceReference1.Get_ListStudentsCourseClassNameResponse> Get_ListStudentsCourseClassNameAsync(string className) {
            WSClient.ServiceReference1.Get_ListStudentsCourseClassNameRequest inValue = new WSClient.ServiceReference1.Get_ListStudentsCourseClassNameRequest();
            inValue.Body = new WSClient.ServiceReference1.Get_ListStudentsCourseClassNameRequestBody();
            inValue.Body.className = className;
            return ((WSClient.ServiceReference1.WebService1Soap)(this)).Get_ListStudentsCourseClassNameAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WSClient.ServiceReference1.Get_Top5StudentsResponse WSClient.ServiceReference1.WebService1Soap.Get_Top5Students(WSClient.ServiceReference1.Get_Top5StudentsRequest request) {
            return base.Channel.Get_Top5Students(request);
        }
        
        public string Get_Top5Students(string semester) {
            WSClient.ServiceReference1.Get_Top5StudentsRequest inValue = new WSClient.ServiceReference1.Get_Top5StudentsRequest();
            inValue.Body = new WSClient.ServiceReference1.Get_Top5StudentsRequestBody();
            inValue.Body.semester = semester;
            WSClient.ServiceReference1.Get_Top5StudentsResponse retVal = ((WSClient.ServiceReference1.WebService1Soap)(this)).Get_Top5Students(inValue);
            return retVal.Body.Get_Top5StudentsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WSClient.ServiceReference1.Get_Top5StudentsResponse> WSClient.ServiceReference1.WebService1Soap.Get_Top5StudentsAsync(WSClient.ServiceReference1.Get_Top5StudentsRequest request) {
            return base.Channel.Get_Top5StudentsAsync(request);
        }
        
        public System.Threading.Tasks.Task<WSClient.ServiceReference1.Get_Top5StudentsResponse> Get_Top5StudentsAsync(string semester) {
            WSClient.ServiceReference1.Get_Top5StudentsRequest inValue = new WSClient.ServiceReference1.Get_Top5StudentsRequest();
            inValue.Body = new WSClient.ServiceReference1.Get_Top5StudentsRequestBody();
            inValue.Body.semester = semester;
            return ((WSClient.ServiceReference1.WebService1Soap)(this)).Get_Top5StudentsAsync(inValue);
        }
    }
}
