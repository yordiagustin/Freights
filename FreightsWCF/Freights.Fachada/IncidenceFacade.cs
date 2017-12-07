using System;
using System.Collections.Generic;
using Freights.ContratoRepositorio;
using Freights.Dominio;
using Freights.RepositorioSQL;

namespace Freights.Fachada
{
    public class IncidenceFacade : IDisposable
    {
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public Incidence SaveIncidence(Incidence incidence)
        {
            IIncidenceRepository repository = new IncidenceRepository();
            return repository.SaveIncidence(incidence);
        }

        public Incidence UpdateIncidence(Incidence incidence)
        {
            IIncidenceRepository repository = new IncidenceRepository();
            return repository.UpdateIncidence(incidence);
        }

        public bool DeleteIncidence(int incidenceId)
        {
            IIncidenceRepository repository = new IncidenceRepository();
            return repository.DeleteIncidence(incidenceId);
        }

        public IEnumerable<Incidence> GetAllIncidences()
        {
            IIncidenceRepository repository = new IncidenceRepository();
            return repository.GetAllIncidences();
        }

        public IEnumerable<Incidence> GetIncidenceByCode(int orderId)
        {
            IIncidenceRepository repository = new IncidenceRepository();
            return repository.GetIncidenceByCode(orderId);
        }

        public Incidence GetIncidence(int incidenceId)
        {
            IIncidenceRepository repository = new IncidenceRepository();
            return repository.GetIncidence(incidenceId);
        }
    }
}
