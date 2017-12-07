using System;
using System.Collections.Generic;
using System.Text;
using Freights.Dominio;

namespace Freights.ContratoRepositorio
{
    public interface IIncidenceRepository
    {
        Incidence SaveIncidence(Incidence incidence);
        Incidence UpdateIncidence(Incidence incidence);
        bool DeleteIncidence(int incidenceId);
        IEnumerable<Incidence> GetAllIncidences();
        IEnumerable<Incidence> GetIncidenceByCode(int orderId);
        Incidence GetIncidence(int incidenceId);
    }
}
