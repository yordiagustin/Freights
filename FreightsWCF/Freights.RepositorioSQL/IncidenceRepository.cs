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
    public class IncidenceRepository : IIncidenceRepository
    {
        public Incidence SaveIncidence(Incidence incidence)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionRepository.GetConnectionString()))
            {
                connection.Open();
                var parameters = new DynamicParameters();
                parameters.Add("date", incidence.Date);
                parameters.Add("latitude", incidence.Latitude);
                parameters.Add("longitude", incidence.Longitude);
                parameters.Add("message", incidence.Message);
                parameters.Add("orderId", incidence.OrderId);
                parameters.Add("incidenceId", 0);

                connection.ExecuteScalar("sp_add_incidence", param: parameters,
                    commandType: CommandType.StoredProcedure);

                var incidenceId = parameters.Get<Int32>("incidenceId");

                incidence.Id = incidenceId;

                return incidence;
            }
        }

        public Incidence UpdateIncidence(Incidence incidence)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionRepository.GetConnectionString()))
            {
                connection.Open();
                var parameters = new DynamicParameters();
                parameters.Add("incidenceId", incidence.Id);
                parameters.Add("date", incidence.Date);
                parameters.Add("latitude", incidence.Latitude);
                parameters.Add("longitude", incidence.Longitude);
                parameters.Add("message", incidence.Message);
                parameters.Add("orderId", incidence.OrderId);

                var result = connection.Execute("sp_update_incidence", param: parameters,
                    commandType: CommandType.StoredProcedure);
                return result > 0 ? incidence : new Incidence();
            }
        }

        public bool DeleteIncidence(int incidenceId)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionRepository.GetConnectionString()))
            {
                connection.Open();
                var parameters = new DynamicParameters();
                parameters.Add("incidenceId", incidenceId);

                var result = connection.Execute("sp_delete_incidence", param: parameters,
                    commandType: CommandType.StoredProcedure);
                return result > 0;
            }
        }

        public IEnumerable<Incidence> GetAllIncidences()
        {
            using (IDbConnection connection = new SqlConnection(ConnectionRepository.GetConnectionString()))
            {
                connection.Open();
                var incidences = connection.Query<Incidence>("sp_all_incidences", commandType: CommandType.StoredProcedure);
                return incidences;
            }
        }

        public IEnumerable<Incidence> GetIncidenceByCode(int orderId)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionRepository.GetConnectionString()))
            {
                connection.Open();
                var parameters = new DynamicParameters();
                parameters.Add("orderId", orderId);

                var incidences = connection.Query<Incidence>("sp_find_incidences_order", param: parameters ,commandType: CommandType.StoredProcedure);
                return incidences;
            }
        }
        

        public Incidence GetIncidence(int incidenceId)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionRepository.GetConnectionString()))
            {
                connection.Open();
                var parameters = new DynamicParameters();
                parameters.Add("incidenceId", incidenceId);

                var driver = connection.QuerySingle<Incidence>("sp_find_incidence_id", commandType: CommandType.StoredProcedure);
                return driver;
            }
        }
    }
}
