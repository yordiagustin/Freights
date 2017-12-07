using System;
using System.Collections.Generic;
using System.Text;
using Freights.Contrato;
using Freights.Dominio;
using Freights.Fachada;

namespace Freights.Implementacion
{
    public class IncidenceService : IIncidenceService
    {
        public Incidence SaveIncidence(Incidence incidence)
        {
            using (var instance = new IncidenceFacade())
            {
                return instance.SaveIncidence(incidence);
            }
        }

        public Incidence UpdateIncidence(Incidence incidence)
        {
            using (var instance = new IncidenceFacade())
            {
                return instance.UpdateIncidence(incidence);
            }

        }

        public bool DeleteIncidence(int incidenceId)
        {
            using (var instance = new IncidenceFacade())
            {
                return instance.DeleteIncidence(incidenceId);
            }
        }

        public IEnumerable<Incidence> GetAllIncidences()
        {
            using (var instance = new IncidenceFacade())
            {
                return instance.GetAllIncidences();
            }
        }

        public IEnumerable<Incidence> GetIncidenceByCode(int orderId)
        {
            using (var instance = new IncidenceFacade())
            {
                return instance.GetIncidenceByCode(orderId);
            }
        }

        public Incidence GetIncidence(int incidenceId)
        {
            using (var instance = new IncidenceFacade())
            {
                return instance.GetIncidence(incidenceId);
            }
        }
    }
}
