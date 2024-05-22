using Application.DTOs.TBOS.Masters;
using Application.Interfaces.TBOS.Masters.Transport;
using Domain.Settings;
using Infrastructure.Persistance.Services.TBOS.Masters.Customer;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Text.RegularExpressions;
using MediatR;
using Amazon.Runtime.Internal;

namespace Infrastructure.Persistance.Services.TBOS.Masters.Transport
{
    public class TransportMasterService : DABase, ITransportMaster
    {
        APISettings _settings;
        private ILogger<TransportMasterService> _logger;
        private const string SP_TransportMaster_ReadAll = "master.TransportMaster_ReadAll";
        private const string SP_TransportMaster_Insert = "master.TransportMaster_Insert";
        private const string SP_TransportMaster_Update = "master.TransportMaster_Update";
        private const string SP_TransportMaster_ReadById = "master.TransportMaster_ReadById";
        private const string SP_TransportMaster_Delete = "master.TransportMaster_Delete";

        public TransportMasterService(IOptions<ConnectionSettings> connectionSettings, ILogger<TransportMasterService> logger, IOptions<APISettings> settings) : base(connectionSettings.Value.AppKeyPath)
        {
            _logger = logger;
            _settings = settings.Value;
        }


        public async Task<TransportList> ReadAll()
        {
            TransportList response = new TransportList();
            _logger.LogInformation($"Started reading all Transports");
            try
            {
                using (SqlConnection connection = new SqlConnection(base.ConnectionString))
                {
                    response.Items = await connection.QueryAsync<TransportMasterDTO>(SP_TransportMaster_ReadAll, commandType: CommandType.StoredProcedure);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response;
        }
        public async Task<TransportMasterDTO> Create(CreateTransport createTransport)
        {
            TransportMasterDTO response = new TransportMasterDTO();
            _logger.LogInformation($"Started creating  Transport : "+ createTransport.TransportName);
            try
            {
                using (SqlConnection connection = new SqlConnection(base.ConnectionString))
                {
                    response = await connection.QuerySingleAsync<TransportMasterDTO>(SP_TransportMaster_Insert, new
                    {
                        TransportName = createTransport.TransportName,
                        BranchCode = createTransport.BranchCode,
                        Specialization = createTransport.Specialization,
                        TransportStatus = createTransport.TransportStatus,
                        BranchId = createTransport.BranchId,
                        CGST = createTransport.CGST,
                        SGST = createTransport.SGST,
                        IGST = createTransport.IGST,
                        UTGST = createTransport.UTGST,
                        GSTIN_No = createTransport.GSTIN_No,
                        GSTReverseCharge = createTransport.GSTReverseCharge,
                        ActionUser = createTransport.ActionUser
                    }, commandType: CommandType.StoredProcedure);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }
        public async Task<TransportMasterDTO> Update(UpdateTransport updateTransport)
        {
            TransportMasterDTO response = new TransportMasterDTO();
            _logger.LogInformation($"Started creating  Transport : " + updateTransport.TransportName);
            try
            {
                using (SqlConnection connection = new SqlConnection(base.ConnectionString))
                {
                    response = await connection.QuerySingleAsync<TransportMasterDTO>(SP_TransportMaster_Update, new
                    {
                        TransportId = updateTransport.TransportId,
                        TransportName = updateTransport.TransportName,
                        BranchCode = updateTransport.BranchCode,
                        Specialization = updateTransport.Specialization,
                        TransportStatus = updateTransport.TransportStatus,
                        BranchId = updateTransport.BranchId,
                        CGST = updateTransport.CGST,
                        SGST = updateTransport.SGST,
                        IGST = updateTransport.IGST,
                        UTGST = updateTransport.UTGST,
                        GSTIN_No = updateTransport.GSTIN_No,
                        GSTReverseCharge = updateTransport.GSTReverseCharge,
                        ActionUser = updateTransport.ActionUser
                    }, commandType: CommandType.StoredProcedure);
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            return response;
        }


        public async Task<TransportMasterDTO> ReadById(int TransportId)
        {
            TransportMasterDTO response = new TransportMasterDTO();
            _logger.LogInformation($"Started reading Transport : " + TransportId);
            try
            {
                using (SqlConnection connection = new SqlConnection(base.ConnectionString))
                {
                    response = await connection.QuerySingleAsync<TransportMasterDTO>(SP_TransportMaster_ReadById,new 
                    {
                        TransportId = TransportId
                    }, commandType: CommandType.StoredProcedure);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response;
        }

        public async Task<Unit> Delete(DeleteTransport deleteTransport)
        {
            _logger.LogInformation($"Started deleting Transport: {deleteTransport.TransportId}");
            try
            {
                using (SqlConnection connection = new SqlConnection(base.ConnectionString))
                {
                    await connection.ExecuteAsync(
                        SP_TransportMaster_Delete,
                        new
                        {
                            TransportId = deleteTransport.TransportId,
                            ActionUser = deleteTransport.ActionUser
                        },
                        commandType: CommandType.StoredProcedure
                    );
                }
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error deleting Transport: {ex.Message}");
                throw; // Preserve the original exception
            }
            return Unit.Value; // Indicate successful deletion
        }

    }

}
