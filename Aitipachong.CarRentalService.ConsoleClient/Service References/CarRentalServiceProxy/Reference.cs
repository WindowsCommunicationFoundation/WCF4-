﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.42000
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Aitipachong.CarRentalService.ConsoleClient.CarRentalServiceProxy {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="CarRentalServiceProxy.ICarRentalService")]
    public interface ICarRentalService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarRentalService/CalulatePrice", ReplyAction="http://tempuri.org/ICarRentalService/CalulatePriceResponse")]
        double CalulatePrice(System.DateTime pickupDate, System.DateTime returnDate, string pickupLocation, string vehiclePreference);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICarRentalService/CalulatePrice", ReplyAction="http://tempuri.org/ICarRentalService/CalulatePriceResponse")]
        System.Threading.Tasks.Task<double> CalulatePriceAsync(System.DateTime pickupDate, System.DateTime returnDate, string pickupLocation, string vehiclePreference);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICarRentalServiceChannel : Aitipachong.CarRentalService.ConsoleClient.CarRentalServiceProxy.ICarRentalService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CarRentalServiceClient : System.ServiceModel.ClientBase<Aitipachong.CarRentalService.ConsoleClient.CarRentalServiceProxy.ICarRentalService>, Aitipachong.CarRentalService.ConsoleClient.CarRentalServiceProxy.ICarRentalService {
        
        public CarRentalServiceClient() {
        }
        
        public CarRentalServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CarRentalServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CarRentalServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CarRentalServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double CalulatePrice(System.DateTime pickupDate, System.DateTime returnDate, string pickupLocation, string vehiclePreference) {
            return base.Channel.CalulatePrice(pickupDate, returnDate, pickupLocation, vehiclePreference);
        }
        
        public System.Threading.Tasks.Task<double> CalulatePriceAsync(System.DateTime pickupDate, System.DateTime returnDate, string pickupLocation, string vehiclePreference) {
            return base.Channel.CalulatePriceAsync(pickupDate, returnDate, pickupLocation, vehiclePreference);
        }
    }
}
