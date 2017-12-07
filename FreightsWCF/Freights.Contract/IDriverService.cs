using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using Freights.Domain;

namespace Freights.Contract
{
    [ServiceContract]
    public interface IDriverService
    {

        [OperationContract]
        [Description("Servicio REST que permite registrar conductores")]
        [WebInvoke(RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            Method = "POST",
            UriTemplate = "/SaveDriver",
            BodyStyle = WebMessageBodyStyle.Bare)]
        Driver SaveDriver(Driver driver);

        [OperationContract]
        [Description("Servicio REST que permite eliminar conductores")]
        [WebInvoke(RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            Method = "DELETE",
            UriTemplate = "/DeleteDriver/{driverId}",
            BodyStyle = WebMessageBodyStyle.Bare)]
        bool DeleteDriver(int driverId);

        [OperationContract]
        [Description("Servicio REST que permite actualizar conductores")]
        [WebInvoke(RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            Method = "PUT",
            UriTemplate = "/UpdateDriver",
            BodyStyle = WebMessageBodyStyle.Bare)]
        Driver UpdateDriver(Driver driver);

        [OperationContract]
        [Description("Servicio REST que obtiene la información de todas los conductores")]
        [WebGet(RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/GetAllDrivers",
            BodyStyle = WebMessageBodyStyle.Bare)]
        IEnumerable<Driver> GetAllDrivers();

        [OperationContract]
        [Description("Servicio REST que obtiene la información de un conductor en específico ")]
        [WebGet(RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/GetDriver",
            BodyStyle = WebMessageBodyStyle.Bare)]
        Driver GetDriver(int driverId);

        [OperationContract]
        [Description("Servicio REST que obtiene las credenciales de autenticación del conductor")]
        [WebGet(RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/DriverLogin",
            BodyStyle = WebMessageBodyStyle.Bare)]
        Driver GetDriverByLoginCode(string loginCode);
    }
}
