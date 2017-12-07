using System;
using System.Collections.Generic;
using System.Text;
using Freights.Dominio;

namespace Freights.ContratoRepositorio
{
    public interface IDriverRepository
    {
        Driver SaveDriver(Driver driver);
        bool DeleteDriver(int driverId);
        Driver UpdateDriver(Driver driver);
        IEnumerable<Driver> GetAllDrivers();
        Driver GetDriver(int driverId);
        Driver GetDriverByLoginCode(string loginCode);
    }
}
