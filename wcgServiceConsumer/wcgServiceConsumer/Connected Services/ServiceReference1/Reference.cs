﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace wcgServiceConsumer.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Student", Namespace="http://schemas.datacontract.org/2004/07/WcfServiceOpgave")]
    [System.SerializableAttribute()]
    public partial class Student : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int AgeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SSNField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Address {
            get {
                return this.AddressField;
            }
            set {
                if ((object.ReferenceEquals(this.AddressField, value) != true)) {
                    this.AddressField = value;
                    this.RaisePropertyChanged("Address");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Age {
            get {
                return this.AgeField;
            }
            set {
                if ((this.AgeField.Equals(value) != true)) {
                    this.AgeField = value;
                    this.RaisePropertyChanged("Age");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SSN {
            get {
                return this.SSNField;
            }
            set {
                if ((this.SSNField.Equals(value) != true)) {
                    this.SSNField = value;
                    this.RaisePropertyChanged("SSN");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddStudent", ReplyAction="http://tempuri.org/IService1/AddStudentResponse")]
        void AddStudent(wcgServiceConsumer.ServiceReference1.Student student);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AddStudent", ReplyAction="http://tempuri.org/IService1/AddStudentResponse")]
        System.Threading.Tasks.Task AddStudentAsync(wcgServiceConsumer.ServiceReference1.Student student);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/FindStudents", ReplyAction="http://tempuri.org/IService1/FindStudentsResponse")]
        void FindStudents(int ssn);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/FindStudents", ReplyAction="http://tempuri.org/IService1/FindStudentsResponse")]
        System.Threading.Tasks.Task FindStudentsAsync(int ssn);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllStudents", ReplyAction="http://tempuri.org/IService1/GetAllStudentsResponse")]
        void GetAllStudents();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllStudents", ReplyAction="http://tempuri.org/IService1/GetAllStudentsResponse")]
        System.Threading.Tasks.Task GetAllStudentsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/RemoveStudent", ReplyAction="http://tempuri.org/IService1/RemoveStudentResponse")]
        void RemoveStudent(wcgServiceConsumer.ServiceReference1.Student student);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/RemoveStudent", ReplyAction="http://tempuri.org/IService1/RemoveStudentResponse")]
        System.Threading.Tasks.Task RemoveStudentAsync(wcgServiceConsumer.ServiceReference1.Student student);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EditStudent", ReplyAction="http://tempuri.org/IService1/EditStudentResponse")]
        void EditStudent(string name, int age, wcgServiceConsumer.ServiceReference1.Student student);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/EditStudent", ReplyAction="http://tempuri.org/IService1/EditStudentResponse")]
        System.Threading.Tasks.Task EditStudentAsync(string name, int age, wcgServiceConsumer.ServiceReference1.Student student);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : wcgServiceConsumer.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<wcgServiceConsumer.ServiceReference1.IService1>, wcgServiceConsumer.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddStudent(wcgServiceConsumer.ServiceReference1.Student student) {
            base.Channel.AddStudent(student);
        }
        
        public System.Threading.Tasks.Task AddStudentAsync(wcgServiceConsumer.ServiceReference1.Student student) {
            return base.Channel.AddStudentAsync(student);
        }
        
        public void FindStudents(int ssn) {
            base.Channel.FindStudents(ssn);
        }
        
        public System.Threading.Tasks.Task FindStudentsAsync(int ssn) {
            return base.Channel.FindStudentsAsync(ssn);
        }
        
        public void GetAllStudents() {
            base.Channel.GetAllStudents();
        }
        
        public System.Threading.Tasks.Task GetAllStudentsAsync() {
            return base.Channel.GetAllStudentsAsync();
        }
        
        public void RemoveStudent(wcgServiceConsumer.ServiceReference1.Student student) {
            base.Channel.RemoveStudent(student);
        }
        
        public System.Threading.Tasks.Task RemoveStudentAsync(wcgServiceConsumer.ServiceReference1.Student student) {
            return base.Channel.RemoveStudentAsync(student);
        }
        
        public void EditStudent(string name, int age, wcgServiceConsumer.ServiceReference1.Student student) {
            base.Channel.EditStudent(name, age, student);
        }
        
        public System.Threading.Tasks.Task EditStudentAsync(string name, int age, wcgServiceConsumer.ServiceReference1.Student student) {
            return base.Channel.EditStudentAsync(name, age, student);
        }
    }
}
