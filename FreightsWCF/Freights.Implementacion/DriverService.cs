using System;
using System.Collections.Generic;
using System.Text;
using Freights.Contrato;
using Freights.Dominio;
using Freights.Fachada;

namespace Freights.Implementacion
{
    public class DriverService : IDriverService
    {
        public Driver SaveDriver(Driver driver)
        {
            using (var instance = new DriverFacade())
            {
                return instance.SaveDriver(driver);
            }
        }

        public bool DeleteDriver(int driverId)
        {
            using (var instance = new DriverFacade())
            {
                return instance.DeleteDriver(driverId);
            }
        }

        public Driver UpdateDriver(Driver driver)
        {
            using (var instance = new DriverFacade())
            {
                return instance.UpdateDriver(driver);
            }
        }

        public IEnumerable<Driver> GetAllDrivers()
        {
            using (var instance = new DriverFacade())
            {
                return instance.GetAllDrivers();
            }
        }

        public Driver GetDriver(int driverId)
        {
            using (var instance = new DriverFacade())
            {
                return instance.GetDriver(driverId);
            }
        }

        public Driver GetDriverByLoginCode(string loginCode)
        {
            using (var instance = new DriverFacade())
            {
                return instance.GetDriverByLoginCode(loginCode);
            }
        }
    }
}
