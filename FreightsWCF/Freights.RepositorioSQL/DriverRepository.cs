using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Dapper;
using Freights.ContratoRepositorio;
using Freights.Dominio;

namespace Freights.RepositorioSQL
{
    public class DriverRepository : IDriverRepository
    {
        public Driver SaveDriver(Driver driver)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionRepository.GetConnectionString()))
            {
                connection.Open();
                var parameters = new DynamicParameters();
                parameters.Add("name", driver.Name);
                parameters.Add("surname", driver.Surname);
                parameters.Add("dni", driver.Dni);
                parameters.Add("address", driver.Address);
                parameters.Add("loginCode", driver.LoginCode);
                parameters.Add("licenseNumber", driver.LicenseNumber);
                parameters.Add("licenseCategory", driver.LicenseCategory);
                parameters.Add("status", driver.Status);
                parameters.Add("driverId", 0);

                connection.ExecuteScalar("sp_add_driver", param: parameters,
                    commandType: CommandType.StoredProcedure);

                var driverId = parameters.Get<Int32>("driverId");

                driver.Id = driverId;

                return driver;
            }
        }

        public bool DeleteDriver(int driverId)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionRepository.GetConnectionString()))
            {
                connection.Open();
                var parameters = new DynamicParameters();
                parameters.Add("driverId", driverId);

                var result = connection.Execute("sp_delete_driver", param: parameters,
                    commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }

        public Driver UpdateDriver(Driver driver)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionRepository.GetConnectionString()))
            {
                connection.Open();
                var parameters = new DynamicParameters();
                parameters.Add("driverId", driver.Id);
                parameters.Add("name", driver.Name);
                parameters.Add("surname", driver.Surname);
                parameters.Add("dni", driver.Dni);
                parameters.Add("address", driver.Address);
                parameters.Add("loginCode", driver.LoginCode);
                parameters.Add("licenseNumber", driver.LicenseNumber);
                parameters.Add("licenseCategory", driver.LicenseCategory);
                parameters.Add("status", driver.Status);

                var result = connection.Execute("sp_update_driver", param: parameters,
                    commandType: CommandType.StoredProcedure);
                return result > 0 ? driver : new Driver();
            }
        }

        public IEnumerable<Driver> GetAllDrivers()
        {
            using (IDbConnection connection = new SqlConnection(ConnectionRepository.GetConnectionString()))
            {
                connection.Open();
                var drivers = connection.Query<Driver>("sp_all_drivers", commandType:CommandType.StoredProcedure);
                return drivers;
            }
        }

        public Driver GetDriver(int driverId)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionRepository.GetConnectionString()))
            {
                connection.Open();
                var parameters = new DynamicParameters();
                parameters.Add("driverId", driverId);

                var driver = connection.QuerySingle<Driver>("sp_find_driver_id", param:parameters,commandType: CommandType.StoredProcedure);
                return driver;
            }
        }

        public Driver GetDriverByLoginCode(string loginCode)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionRepository.GetConnectionString()))
            {
                connection.Open();
                var parameters = new DynamicParameters();
                parameters.Add("loginCode", loginCode);

                var driver = connection.QuerySingle<Driver>("sp_login_driver", param: parameters, commandType: CommandType.StoredProcedure);
                return driver;
            }
        }
    }
}
