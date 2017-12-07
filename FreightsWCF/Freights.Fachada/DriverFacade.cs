using System;
using System.Collections.Generic;
using System.Text;
using Freights.ContratoRepositorio;
using Freights.Dominio;
using Freights.RepositorioSQL;

namespace Freights.Fachada
{
    public class DriverFacade : IDisposable
    {
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }

        public Driver SaveDriver(Driver driver)
        {
            IDriverRepository repository = new DriverRepository();
            return repository.SaveDriver(driver);
        }

        public bool DeleteDriver(int driverId)
        {
            IDriverRepository repository = new DriverRepository();
            return repository.DeleteDriver(driverId);
        }

        public Driver UpdateDriver(Driver driver)
        {
            IDriverRepository repository = new DriverRepository();
            return repository.UpdateDriver(driver);
        }

        public IEnumerable<Driver> GetAllDrivers()
        {
            IDriverRepository repository = new DriverRepository();
            return repository.GetAllDrivers();
        }

        public Driver GetDriver(int driverId)
        {
            IDriverRepository repository = new DriverRepository();
            return repository.GetDriver(driverId);
        }

        // ReSharper disable once FunctionRecursiveOnAllPaths
        public Driver GetDriverByLoginCode(string loginCode)
        {
            IDriverRepository repository = new DriverRepository();
            return GetDriverByLoginCode(loginCode);
        }
    }
}
