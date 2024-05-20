using Application.DTOs.TBOS.Masters;
using Application.Interfaces.TBOS.Masters.Agent;
using Dapper;
using Domain.Settings;
using Infrastructure.Persistance.Services.TBOS.Masters.Transport;
using MediatR;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Infrastructure.Persistance.Services.TBOS.Masters.Agent
{
    public class AgentMasterService : DABase, IAgentMaster
    {
        APISettings _settings;

        private ILogger<AgentMasterService> _logger;

        private const string SP_AgentMaster_ReadAll = "master.AgentMaster_ReadAll";
        private const string SP_AgentMaster_Insert = "master.AgentMaster_Insert";
        private const string SP_AgentMaster_Update = "master.AgentMaster_Update";
        private const string SP_AgentMaster_ReadById = "master.AgentMaster_ReadById";
        private const string SP_AgentMaster_Delete = "master.AgentMaster_Delete";

        public AgentMasterService(IOptions<ConnectionSettings> connectionSettings, ILogger<AgentMasterService> logger, IOptions<APISettings> settings) : base(connectionSettings.Value.AppKeyPath)
        {
            _logger = logger;
            _settings = settings.Value;
        }

        public async Task<AgentList> ReadAll()
        {
            AgentList response = new AgentList();
            _logger.LogInformation($"Started reading all Agents");
            try
            {
                using (SqlConnection connection = new SqlConnection(base.ConnectionString))
                {
                    response.Items = await connection.QueryAsync<AgentMasterDTO>(SP_AgentMaster_ReadAll, commandType: CommandType.StoredProcedure);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response;
        }

        public async Task<AgentMasterDTO> Create(CreateAgent createAgent)
        {
            AgentMasterDTO response = new AgentMasterDTO();
            _logger.LogInformation($"Started creating Agent : " + createAgent.AgentName);
            try
            {
                using (SqlConnection connection = new SqlConnection(base.ConnectionString))
                {
                    response = await connection.QuerySingleAsync<AgentMasterDTO>(SP_AgentMaster_Insert, new
                    {
                        AgentName = createAgent.AgentName,
                        AgentStatus = createAgent.AgentStatus,
                        PanNo = createAgent.PanNo,
                        Zone = createAgent.Zone,
                        AgentCommission = createAgent.AgentCommission,  
                        BranchId = createAgent.BranchId,
                        CGST = createAgent.CGST,
                        SGST = createAgent.SGST,
                        IGST = createAgent.IGST,
                        UTGST = createAgent.UTGST,
                        GSTIN_No = createAgent.GSTIN_No,
                        GSTReverseCharge =  createAgent.GSTReverseCharge,
                        ActionUser = createAgent.ActionUser
                    },
                    commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response;

        }

        public async Task<AgentMasterDTO> Update(UpdateAgent updateAgent)
        {
            AgentMasterDTO response = new AgentMasterDTO();
            _logger.LogInformation($"Started updating Agent : " + updateAgent.AgentName);
            try
            {
                using (SqlConnection connection = new SqlConnection(base.ConnectionString))
                {
                    response = await connection.QuerySingleAsync<AgentMasterDTO>(SP_AgentMaster_Update, new
                    {
                        AgentId = updateAgent.AgentId,
                        AgentName = updateAgent.AgentName,
                        AgentStatus = updateAgent.AgentStatus,
                        PanNo = updateAgent.PanNo,
                        Zone = updateAgent.Zone,
                        AgentCommission = updateAgent.AgentCommission,
                        BranchId = updateAgent.BranchId,
                        CGST = updateAgent.CGST,
                        SGST = updateAgent.SGST,
                        IGST = updateAgent.IGST,
                        UTGST = updateAgent.UTGST,
                        GSTIN_No = updateAgent.GSTIN_No,
                        GSTReverseCharge = updateAgent.GSTReverseCharge,
                        ActionUser = updateAgent.ActionUser
                    },
                    commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response;

        }

        public async Task<AgentMasterDTO> ReadById(int AgentId)
        {
            AgentMasterDTO response = new AgentMasterDTO();
            _logger.LogInformation($"Started reading Agent : " + AgentId);
            try
            {
                using (SqlConnection connection = new SqlConnection(base.ConnectionString))
                {
                    response = await connection.QuerySingleAsync<AgentMasterDTO>(SP_AgentMaster_ReadById, new
                    {
                        AgentId = AgentId
                    }, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response;
        }

        public async Task<Unit> Delete(DeleteAgent deleteAgent)
        {
            _logger.LogInformation($"Started deleting Transport: {deleteAgent.AgentId}");
            try
            {
                using (SqlConnection connection = new SqlConnection(base.ConnectionString))
                {
                    await connection.ExecuteAsync(
                        SP_AgentMaster_Delete,
                        new
                        {
                            AgentId = deleteAgent.AgentId,
                            ActionUser = deleteAgent.ActionUser
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
