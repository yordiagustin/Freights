using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;
using Freights.Dominio;

namespace Freights.Contrato
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
            UriTemplate = "/DeleteDriver/?driverId={driverId}",
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
        [WebGet(RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/GetAllDrivers",
            BodyStyle = WebMessageBodyStyle.Bare)]
        IEnumerable<Driver> GetAllDrivers();

        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/GetDriverId/?driverId={driverId}",
            BodyStyle = WebMessageBodyStyle.Bare)]
        Driver GetDriver(int driverId);

        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/LoginDriver/?loginCode={loginCode}",
            BodyStyle = WebMessageBodyStyle.Bare)]
        Driver GetDriverByLoginCode(string loginCode);
    }
}
