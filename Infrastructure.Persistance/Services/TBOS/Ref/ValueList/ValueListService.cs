using Application.DTOs.TBOS.Ref.ValueList;
using Application.DTOs.TBOS.UserControl;
using Application.Interfaces.TBOS.Ref.ValueList;
using Dapper;
using Domain.Settings;
using Infrastructure.Persistance.Services.TBOS.UC.Address;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistance.Services.TBOS.Ref.ValueList
{
    public class ValueListService : DABase, IValueList
    {
        APISettings _settings;
        private ILogger<ValueListService> _logger;

        private const string SP_ValueList_Insert = "ref.ValueList_Insert";
        private const string SP_ValueList_Update = "ref.ValueList_Update";
        private const string SP_ValueList_ReadAll = "ref.ValueList_ReadAll";


        public ValueListService(IOptions<ConnectionSettings> connectionSettings, ILogger<ValueListService> logger, IOptions<APISettings> settings) : base(connectionSettings.Value.AppKeyPath)
        {
            _logger = logger;
            _settings = settings.Value;
        }

        public async Task<ValueListDTO> Create(CreateValueList createValueList)
        {
            ValueListDTO response = new ValueListDTO();
            _logger.LogInformation($"Started creating ValueList : " + createValueList.vlName);

            try
            {
                using (SqlConnection connection = new SqlConnection(base.ConnectionString))
                {
                    response = await connection.QuerySingleAsync<ValueListDTO>(SP_ValueList_Insert, new
                    {
                        vlName = createValueList.vlName,
                        vlCode = createValueList.vlCode,
                        vlDesc = createValueList.vlDesc,
                        ActionUser = createValueList.ActionUser,
                    }, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response;
        }


        public async Task<ValueListDTO> Update(UpdateValueList updateValueList)
        {
            ValueListDTO response = new ValueListDTO();
            _logger.LogInformation($"Started Updating ValueList : " + updateValueList.vlName);

            try
            {
                using (SqlConnection connection = new SqlConnection(base.ConnectionString))
                {
                    response = await connection.QuerySingleAsync<ValueListDTO>(SP_ValueList_Update, new
                    {
                        ValueListId = updateValueList.ValueListId,
                        vlName = updateValueList.vlName,
                        vlCode = updateValueList.vlCode,
                        vlDesc = updateValueList.vlDesc,
                        ActionUser = updateValueList.ActionUser,
                    }, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response;
        }

        public async Task<ValueListAll> ReadAll()
        {
            ValueListAll response = new ValueListAll();
            _logger.LogInformation($"Started Reading ValueList");

            try
            {
                using (SqlConnection connection = new SqlConnection(base.ConnectionString))
                {
                    response.Items = await connection.QueryAsync<ValueListDTO>(SP_ValueList_ReadAll,commandType:CommandType.StoredProcedure);
                }
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return response;
        }
    }
}
