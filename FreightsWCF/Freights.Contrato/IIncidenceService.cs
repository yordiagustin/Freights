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
            UriTemplate = "/DeleteIncidence/?incidenceId={incidenceId}",
            BodyStyle = WebMessageBodyStyle.Bare)]
        bool DeleteIncidence(int incidenceId);

        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/GetAllIncidences",
            BodyStyle = WebMessageBodyStyle.Bare)]
        IEnumerable<Incidence> GetAllIncidences();

        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/GetIncidenceByOrder/?orderId={orderId}",
            BodyStyle = WebMessageBodyStyle.Bare)]
        IEnumerable<Incidence> GetIncidenceByCode(int orderId);

        [OperationContract]
        [WebGet(RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            UriTemplate = "/GetIncidence/?incidenceId={incidenceId}",
            BodyStyle = WebMessageBodyStyle.Bare)]
        Incidence GetIncidence(int incidenceId);
    }
}
