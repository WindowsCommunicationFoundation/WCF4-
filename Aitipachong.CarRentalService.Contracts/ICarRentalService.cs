using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

/**
 * 汽车租赁服务“契约”程序集
 */
namespace Aitipachong.CarRentalService.Contracts
{
    /// <summary>
    /// 汽车租赁服务的服务契约接口
    /// </summary>
    [ServiceContract
        (Namespace="http://aitipachong/CarRentalService/2015/11",
        Name="RentalService")]
    public interface ICarRentalService
    {
        //[OperationContract]
        //PriceCalculationResponse CalculatePrice(PriceCalculationRequest request);


        //[OperationContract]
        //double CheckAvgPricePerDay(string carType);

        /// <summary>
        /// 服务契约内的服务操作契约
        /// </summary>
        /// <param name="pickupDate"></param>
        /// <param name="returnDate"></param>
        /// <param name="pickupLocation"></param>
        /// <param name="vehiclePreference"></param>
        /// <returns></returns>
        [OperationContract]
        double CalulatePrice(DateTime pickupDate, DateTime returnDate, string pickupLocation, string vehiclePreference);
    }
}
