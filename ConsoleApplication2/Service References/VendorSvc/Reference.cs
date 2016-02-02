﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ConsoleApplication2.VendorSvc {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="NAVVendor", Namespace="http://schemas.datacontract.org/2004/07/CoreNAV.DataContracts")]
    [System.SerializableAttribute()]
    public partial class NAVVendor : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BlockedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LegacyVendorNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ConsoleApplication2.VendorSvc.NAVVendorAddress MainAddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ConsoleApplication2.VendorSvc.NAVVendorAddress[] OrderAddressesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OurAccountNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string VendorNumberField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string VendorSearchNameField;
        
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
        public bool Blocked {
            get {
                return this.BlockedField;
            }
            set {
                if ((this.BlockedField.Equals(value) != true)) {
                    this.BlockedField = value;
                    this.RaisePropertyChanged("Blocked");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LegacyVendorNumber {
            get {
                return this.LegacyVendorNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.LegacyVendorNumberField, value) != true)) {
                    this.LegacyVendorNumberField = value;
                    this.RaisePropertyChanged("LegacyVendorNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ConsoleApplication2.VendorSvc.NAVVendorAddress MainAddress {
            get {
                return this.MainAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.MainAddressField, value) != true)) {
                    this.MainAddressField = value;
                    this.RaisePropertyChanged("MainAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ConsoleApplication2.VendorSvc.NAVVendorAddress[] OrderAddresses {
            get {
                return this.OrderAddressesField;
            }
            set {
                if ((object.ReferenceEquals(this.OrderAddressesField, value) != true)) {
                    this.OrderAddressesField = value;
                    this.RaisePropertyChanged("OrderAddresses");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OurAccountNumber {
            get {
                return this.OurAccountNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.OurAccountNumberField, value) != true)) {
                    this.OurAccountNumberField = value;
                    this.RaisePropertyChanged("OurAccountNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string VendorNumber {
            get {
                return this.VendorNumberField;
            }
            set {
                if ((object.ReferenceEquals(this.VendorNumberField, value) != true)) {
                    this.VendorNumberField = value;
                    this.RaisePropertyChanged("VendorNumber");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string VendorSearchName {
            get {
                return this.VendorSearchNameField;
            }
            set {
                if ((object.ReferenceEquals(this.VendorSearchNameField, value) != true)) {
                    this.VendorSearchNameField = value;
                    this.RaisePropertyChanged("VendorSearchName");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="NAVVendorAddress", Namespace="http://schemas.datacontract.org/2004/07/CoreNAV.DataContracts")]
    [System.SerializableAttribute()]
    public partial class NAVVendorAddress : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string AddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Address2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private ConsoleApplication2.VendorSvc.NAVAddressType AddressTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool AllowDropShipmentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CityField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ContactField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CountryCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FaxNoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string HomepageField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string Name2Field;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OrderCutoffTimeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PhoneNoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PostCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PostCodeTimeZoneField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ShipmentMethodCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ShippingAgentCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ShippingAgentServiceCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StateField;
        
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
        public string Address2 {
            get {
                return this.Address2Field;
            }
            set {
                if ((object.ReferenceEquals(this.Address2Field, value) != true)) {
                    this.Address2Field = value;
                    this.RaisePropertyChanged("Address2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public ConsoleApplication2.VendorSvc.NAVAddressType AddressType {
            get {
                return this.AddressTypeField;
            }
            set {
                if ((this.AddressTypeField.Equals(value) != true)) {
                    this.AddressTypeField = value;
                    this.RaisePropertyChanged("AddressType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool AllowDropShipment {
            get {
                return this.AllowDropShipmentField;
            }
            set {
                if ((this.AllowDropShipmentField.Equals(value) != true)) {
                    this.AllowDropShipmentField = value;
                    this.RaisePropertyChanged("AllowDropShipment");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string City {
            get {
                return this.CityField;
            }
            set {
                if ((object.ReferenceEquals(this.CityField, value) != true)) {
                    this.CityField = value;
                    this.RaisePropertyChanged("City");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Code {
            get {
                return this.CodeField;
            }
            set {
                if ((object.ReferenceEquals(this.CodeField, value) != true)) {
                    this.CodeField = value;
                    this.RaisePropertyChanged("Code");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Contact {
            get {
                return this.ContactField;
            }
            set {
                if ((object.ReferenceEquals(this.ContactField, value) != true)) {
                    this.ContactField = value;
                    this.RaisePropertyChanged("Contact");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CountryCode {
            get {
                return this.CountryCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.CountryCodeField, value) != true)) {
                    this.CountryCodeField = value;
                    this.RaisePropertyChanged("CountryCode");
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
        public string FaxNo {
            get {
                return this.FaxNoField;
            }
            set {
                if ((object.ReferenceEquals(this.FaxNoField, value) != true)) {
                    this.FaxNoField = value;
                    this.RaisePropertyChanged("FaxNo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Homepage {
            get {
                return this.HomepageField;
            }
            set {
                if ((object.ReferenceEquals(this.HomepageField, value) != true)) {
                    this.HomepageField = value;
                    this.RaisePropertyChanged("Homepage");
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
        public string Name2 {
            get {
                return this.Name2Field;
            }
            set {
                if ((object.ReferenceEquals(this.Name2Field, value) != true)) {
                    this.Name2Field = value;
                    this.RaisePropertyChanged("Name2");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string OrderCutoffTime {
            get {
                return this.OrderCutoffTimeField;
            }
            set {
                if ((object.ReferenceEquals(this.OrderCutoffTimeField, value) != true)) {
                    this.OrderCutoffTimeField = value;
                    this.RaisePropertyChanged("OrderCutoffTime");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PhoneNo {
            get {
                return this.PhoneNoField;
            }
            set {
                if ((object.ReferenceEquals(this.PhoneNoField, value) != true)) {
                    this.PhoneNoField = value;
                    this.RaisePropertyChanged("PhoneNo");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PostCode {
            get {
                return this.PostCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.PostCodeField, value) != true)) {
                    this.PostCodeField = value;
                    this.RaisePropertyChanged("PostCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PostCodeTimeZone {
            get {
                return this.PostCodeTimeZoneField;
            }
            set {
                if ((object.ReferenceEquals(this.PostCodeTimeZoneField, value) != true)) {
                    this.PostCodeTimeZoneField = value;
                    this.RaisePropertyChanged("PostCodeTimeZone");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ShipmentMethodCode {
            get {
                return this.ShipmentMethodCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.ShipmentMethodCodeField, value) != true)) {
                    this.ShipmentMethodCodeField = value;
                    this.RaisePropertyChanged("ShipmentMethodCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ShippingAgentCode {
            get {
                return this.ShippingAgentCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.ShippingAgentCodeField, value) != true)) {
                    this.ShippingAgentCodeField = value;
                    this.RaisePropertyChanged("ShippingAgentCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string ShippingAgentServiceCode {
            get {
                return this.ShippingAgentServiceCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.ShippingAgentServiceCodeField, value) != true)) {
                    this.ShippingAgentServiceCodeField = value;
                    this.RaisePropertyChanged("ShippingAgentServiceCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string State {
            get {
                return this.StateField;
            }
            set {
                if ((object.ReferenceEquals(this.StateField, value) != true)) {
                    this.StateField = value;
                    this.RaisePropertyChanged("State");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="NAVAddressType", Namespace="http://schemas.datacontract.org/2004/07/CoreNAV.DataContracts")]
    public enum NAVAddressType : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Business = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        None = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Residence = 2,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="VendorSvc.IVendorSvc")]
    public interface IVendorSvc {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVendorSvc/GetVendors", ReplyAction="http://tempuri.org/IVendorSvc/GetVendorsResponse")]
        ConsoleApplication2.VendorSvc.NAVVendor[] GetVendors();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVendorSvc/GetVendors", ReplyAction="http://tempuri.org/IVendorSvc/GetVendorsResponse")]
        System.Threading.Tasks.Task<ConsoleApplication2.VendorSvc.NAVVendor[]> GetVendorsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVendorSvc/SaySomething", ReplyAction="http://tempuri.org/IVendorSvc/SaySomethingResponse")]
        string SaySomething();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IVendorSvc/SaySomething", ReplyAction="http://tempuri.org/IVendorSvc/SaySomethingResponse")]
        System.Threading.Tasks.Task<string> SaySomethingAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IVendorSvcChannel : ConsoleApplication2.VendorSvc.IVendorSvc, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class VendorSvcClient : System.ServiceModel.ClientBase<ConsoleApplication2.VendorSvc.IVendorSvc>, ConsoleApplication2.VendorSvc.IVendorSvc {
        
        public VendorSvcClient() {
        }
        
        public VendorSvcClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public VendorSvcClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VendorSvcClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public VendorSvcClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public ConsoleApplication2.VendorSvc.NAVVendor[] GetVendors() {
            return base.Channel.GetVendors();
        }
        
        public System.Threading.Tasks.Task<ConsoleApplication2.VendorSvc.NAVVendor[]> GetVendorsAsync() {
            return base.Channel.GetVendorsAsync();
        }
        
        public string SaySomething() {
            return base.Channel.SaySomething();
        }
        
        public System.Threading.Tasks.Task<string> SaySomethingAsync() {
            return base.Channel.SaySomethingAsync();
        }
    }
}