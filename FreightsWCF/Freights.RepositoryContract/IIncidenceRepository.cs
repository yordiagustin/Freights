using System;
using System.Collections.Generic;
using System.Text;
using Freights.Domain;

namespace Freights.RepositoryContract
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
