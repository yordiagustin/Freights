using System;
using System.Collections.Generic;
using System.Text;
using Freights.Domain;

namespace Freights.RepositoryContract
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
