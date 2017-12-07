using Freights.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace Freights.Contract
{
    [ServiceContract]
    public interface IIncidenceService
    {
        [OperationContract]
        [Description("Servicio REST que permite registrar incidencias")]
        [WebInvoke(RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            Method = "POST",
            UriTemplate = "/SaveIncidence",
            BodyStyle = WebMessageBodyStyle.Bare)]
        Incidence SaveIncidence(Incidence incidence);

        [OperationContract]
        [Description("Servicio REST que permite actualizar incidencias")]
        [WebInvoke(RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            Method = "PUT",
            UriTemplate = "/UpdateIncidence",
            BodyStyle = WebMessageBodyStyle.Bare)]
        Incidence UpdateIncidence(Incidence incidence);

        [OperationContract]
        [Description("Servicio REST que permite eliminar incidencias")]
        [WebInvoke(RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            Method = "DELETE",
            UriTemplate = "/DeleteIncidence/{incidenceId}",
            BodyStyle = WebMessageBodyStyle.Bare)]
        bool DeleteIncidence(int incidenceId);

        [OperationContract]
        [Description("Servicio REST que obtiene la información de todas las incidencias")]
        [WebGet(RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/GetAllIncidences",
            BodyStyle = WebMessageBodyStyle.Bare)]
        IEnumerable<Incidence> GetAllIncidences();

        [OperationContract]
        [Description("Servicio REST que obtiene la información de una incidencia por el código de una órden")]
        [WebGet(RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/GetIncidenceByCode/{orderId}",
            BodyStyle = WebMessageBodyStyle.Bare)]
        IEnumerable<Incidence> GetIncidenceByCode(int orderId);

        [OperationContract]
        [Description("Servicio REST que obtiene la información de una incidencia en específico.")]
        [WebGet(RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/GetIncidence/{incidenceId}",
            BodyStyle = WebMessageBodyStyle.Bare)]
        Incidence GetIncidence(int incidenceId);
        
    }
}
