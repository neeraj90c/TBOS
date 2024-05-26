using Application.DTOs.TBOS.Ref.ValueList;
using Application.Interfaces.TBOS.Ref.ValueListItem;
using Domain.Settings;
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

namespace Infrastructure.Persistance.Services.TBOS.Ref.ValueList
{
    public class ValueListItemService : DABase, IValueListItem
    {
        APISettings _settings;
        private ILogger<ValueListItemService> _logger;

        private const string SP_ValueListItem_Insert = "ref.ValueListItem_Insert";
        private const string SP_ValueListItem_Update = "ref.ValueListItem_Update";
        private const string SP_ValueListItem_ReadByValueListId = "ref.ValueListItem_ReadByValueListId";
        private const string SP_ValueListItem_ReadByVLName = "ref.ValueListItem_ReadByVLName";


        public ValueListItemService(IOptions<ConnectionSettings> connectionSettings, ILogger<ValueListItemService> logger, IOptions<APISettings> settings) : base(connectionSettings.Value.AppKeyPath)
        {
            _logger = logger;
            _settings = settings.Value;
        }

        public async Task<ValueListItemDTO> Create(CreateValueListItem createValueListItem)
        {
            ValueListItemDTO response = new ValueListItemDTO();
            _logger.LogInformation($"Started creating ValueListITem : " + createValueListItem.vliName);

            try
            {
                using (SqlConnection connection = new SqlConnection(base.ConnectionString))
                {
                    response = await connection.QuerySingleAsync<ValueListItemDTO>(SP_ValueListItem_Insert, new
                    {

                        ValuesListId = createValueListItem.vliName,
                        vliName = createValueListItem.vliName,
                        vliCode = createValueListItem.vliCode,
                        vliDesc = createValueListItem.vliDesc,
                        displaySeq = createValueListItem.vliDesc,
                        ActionUser = createValueListItem.ActionUser

                    }, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response;
        }

        public async Task<ValueListItemDTO> Update(UpdateValueListItem updateValueListItem)
        {
            ValueListItemDTO response = new ValueListItemDTO();
            _logger.LogInformation($"Started creating ValueListITem : " + updateValueListItem.vliName);

            try
            {
                using (SqlConnection connection = new SqlConnection(base.ConnectionString))
                {
                    response = await connection.QuerySingleAsync<ValueListItemDTO>(SP_ValueListItem_Update, new
                    {
                        ValueListItemId = updateValueListItem.vliName,
                        ValuesListId = updateValueListItem.vliName,
                        vliName = updateValueListItem.vliName,
                        vliCode = updateValueListItem.vliCode,
                        vliDesc = updateValueListItem.vliDesc,
                        displaySeq = updateValueListItem.vliDesc,
                        ActionUser = updateValueListItem.ActionUser

                    }, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response;
        }

        public async Task<ValueListItemAll> ReadByValueListId(int ValuesListId)
        {
            ValueListItemAll response = new ValueListItemAll();
            _logger.LogInformation($"Started readind ValueListITem fo VLId : " + ValuesListId);

            try
            {
                using (SqlConnection connection = new SqlConnection(base.ConnectionString))
                {
                    response.Items = await connection.QueryAsync<ValueListItemDTO>(SP_ValueListItem_ReadByValueListId, new
                    {
                        ValuesListId = ValuesListId

                    }, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response;
        }

        public async Task<ValueListItemAll> ReadByVLName(string vlName)
        {
            ValueListItemAll response = new ValueListItemAll();
            _logger.LogInformation($"Started readind ValueListITem for vlName : " + vlName);

            try
            {
                using (SqlConnection connection = new SqlConnection(base.ConnectionString))
                {
                    response.Items = await connection.QueryAsync<ValueListItemDTO>(SP_ValueListItem_ReadByVLName, new
                    {
                        vlName = vlName

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
