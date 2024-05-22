using Application.DTOs.TBOS.UserControl;
using Application.Interfaces.TBOS.UC;
using Domain.Settings;
using Infrastructure.Persistance.Services.TBOS.UC.Address;
using MediatR;
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
using System.Diagnostics.Metrics;
using System.Text.RegularExpressions;

namespace Infrastructure.Persistance.Services.TBOS.UC.Address
{
    public class AddressDetailService : DABase, IAddressDetails
    {
        APISettings _settings;
        private ILogger<AddressDetailService> _logger;

        private const string SP_AddressDetail_ReadAll = "uc.AddressDetail_ReadAll";
        private const string SP_AddressDetail_Insert = "uc.AddressDetail_Insert";
        private const string SP_AddressDetail_ReadById = "uc.AddressDetail_ReadById";
        private const string SP_AddressDetail_Update = "uc.AddressDetail_Update";
        private const string SP_AddressDetail_ReadByMasterCode = "uc.AddressDetail_ReadByMasterCode";
        private const string SP_AddressDetail_ReadByMasterCodeDefault = "uc.AddressDetail_ReadByMasterCodeDefault";
        private const string SP_AddressDetail_Delete = "uc.AddressDetail_Delete";

        public AddressDetailService(IOptions<ConnectionSettings> connectionSettings, ILogger<AddressDetailService> logger, IOptions<APISettings> settings) : base(connectionSettings.Value.AppKeyPath)
        {
            _logger = logger;
            _settings = settings.Value;
        }
        public async Task<AddressDetailDTO> Create(CreateAddress createAddress)
        {
            AddressDetailDTO response = new AddressDetailDTO();
            _logger.LogInformation($"Started creating Address : "+ createAddress.MasterCode);
            try
            {
                using (SqlConnection connection = new SqlConnection(base.ConnectionString))
                {
                    response = await connection.QuerySingleAsync<AddressDetailDTO>(SP_AddressDetail_Insert, new
                    {
                        MasterCode = createAddress.MasterCode,
                        AddressType = createAddress.AddressType,
                        add_line1 = createAddress.add_line1,
                        add_line2 = createAddress.add_line2,
                        add_line3 = createAddress.add_line3,
                        add_line4 = createAddress.add_line4,
                        City = createAddress.City,
                        State = createAddress.State,
                        Country = createAddress.Country,
                        Pincode = createAddress.Pincode,
                        Status = createAddress.Status,
                        ActionUser = createAddress.ActionUser

                    }, commandType: CommandType.StoredProcedure);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response;
        }

        public async Task<Unit> Delete(DeleteAddress deleteAddress)
        {
            _logger.LogInformation($"Started deleting Address : " + deleteAddress.DetailId);
            try
            {
                using (SqlConnection connection = new SqlConnection(base.ConnectionString))
                {
                    await connection.ExecuteAsync(
                        SP_AddressDetail_Delete,
                        new
                        {
                            DetailId = deleteAddress.DetailId,
                            ActionUser = deleteAddress.ActionUser
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

        public async Task<AddressList> ReadAll()
        {
            AddressList response = new AddressList();
            _logger.LogInformation($"Started reading all Addresss");
            try
            {
                using (SqlConnection connection = new SqlConnection(base.ConnectionString))
                {
                    response.Items = await connection.QueryAsync<AddressDetailDTO>(SP_AddressDetail_ReadAll, commandType: CommandType.StoredProcedure);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response;
        }

        public async Task<AddressDetailDTO> ReadById(int DetailId)
        {
            AddressDetailDTO response = new AddressDetailDTO();
            _logger.LogInformation($"Started reading Address : " + DetailId);
            try
            {
                using (SqlConnection connection = new SqlConnection(base.ConnectionString))
                {
                    response = await connection.QuerySingleAsync<AddressDetailDTO>(SP_AddressDetail_ReadById, new
                    {
                        DetailId = DetailId,

                    }, commandType: CommandType.StoredProcedure);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response;
        }

        public async Task<AddressList> ReadByMasterCode(string MasterCode)
        {
            AddressList response = new AddressList();
            _logger.LogInformation($"Started reading Address by masterCode: " + MasterCode);
            try
            {
                using (SqlConnection connection = new SqlConnection(base.ConnectionString))
                {
                    response.Items = await connection.QueryAsync<AddressDetailDTO>(SP_AddressDetail_ReadByMasterCode, new
                    {
                        MasterCode = MasterCode,

                    }, commandType: CommandType.StoredProcedure);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response;
        }

        public async Task<AddressDetailDTO> ReadByMasterCodeDefault(string MasterCode)
        {
            AddressDetailDTO response = new AddressDetailDTO();
            _logger.LogInformation($"Started reading Address by masterCode: " + MasterCode);
            try
            {
                using (SqlConnection connection = new SqlConnection(base.ConnectionString))
                {
                    response = await connection.QuerySingleAsync<AddressDetailDTO>(SP_AddressDetail_ReadByMasterCodeDefault, new
                    {
                        MasterCode = MasterCode,

                    }, commandType: CommandType.StoredProcedure);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response;
        }

        public async Task<AddressDetailDTO> Update(UpdateAddress updateAddress)
        {
            AddressDetailDTO response = new AddressDetailDTO();
            _logger.LogInformation($"Started Updating Address : " + updateAddress.DetailId);
            try
            {
                using (SqlConnection connection = new SqlConnection(base.ConnectionString))
                {
                    response = await connection.QuerySingleAsync<AddressDetailDTO>(SP_AddressDetail_Update, new
                    {
                        DetailId = updateAddress.DetailId,
                        MasterCode = updateAddress.MasterCode,
                        AddressType = updateAddress.AddressType,
                        add_line1 = updateAddress.add_line1,
                        add_line2 = updateAddress.add_line2,
                        add_line3 = updateAddress.add_line3,
                        add_line4 = updateAddress.add_line4,
                        City = updateAddress.City,
                        State = updateAddress.State,
                        Country = updateAddress.Country,
                        Pincode = updateAddress.Pincode,
                        Status = updateAddress.Status,
                        ActionUser = updateAddress.ActionUser

                    }, commandType: CommandType.StoredProcedure);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response;
        }
    }
}
