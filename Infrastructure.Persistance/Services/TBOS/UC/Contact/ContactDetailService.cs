using Application.DTOs.TBOS.Masters;
using Application.DTOs.TBOS.UserControl;
using Application.Interfaces.TBOS.UC;
using Domain.Settings;
using Infrastructure.Persistance.Services.TBOS.Masters.Transport;
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
using System.Text.RegularExpressions;

namespace Infrastructure.Persistance.Services.TBOS.UC.Contact
{
    public class ContactDetailService : DABase, IContactDetails
    {
        APISettings _settings;
        private ILogger<ContactDetailService> _logger;

        private const string SP_ContactDetail_ReadAll = "uc.ContactDetail_ReadAll";
        private const string SP_ContactDetail_Insert = "uc.ContactDetail_Insert";
        private const string SP_ContactDetail_ReadById = "uc.ContactDetail_ReadById";
        private const string SP_ContactDetail_Update = "uc.ContactDetail_Update";
        private const string SP_ContactDetail_ReadByMasterCode = "uc.ContactDetail_ReadByMasterCode";
        private const string SP_ContactDetail_ReadByMasterCodeDefault = "uc.ContactDetail_ReadByMasterCodeDefault";
        private const string SP_ContactDetail_Delete = "uc.ContactDetail_Delete";

        public ContactDetailService(IOptions<ConnectionSettings> connectionSettings, ILogger<ContactDetailService> logger, IOptions<APISettings> settings) : base(connectionSettings.Value.AppKeyPath)
        {
            _logger = logger;
            _settings = settings.Value;
        }

        public async Task<ContactList> ReadAll()
        {
            ContactList response = new ContactList();
            _logger.LogInformation($"Started reading all Contacts");
            try
            {
                using (SqlConnection connection = new SqlConnection(base.ConnectionString))
                {
                    response.Items = await connection.QueryAsync<ContactDetailDTO>(SP_ContactDetail_ReadAll, commandType: CommandType.StoredProcedure);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response;
        }

        public async Task<ContactDetailDTO> Create(CreateContact createContact)
        {
            ContactDetailDTO response = new ContactDetailDTO();
            _logger.LogInformation($"Started creating Contact : "+createContact.PersonName);
            try
            {
                using (SqlConnection connection = new SqlConnection(base.ConnectionString))
                {
                    response = await connection.QuerySingleAsync<ContactDetailDTO>(SP_ContactDetail_Insert,new 
                    {
                        MasterCode = createContact.MasterCode,
                        PersonName = createContact.PersonName,
                        Designation = createContact.Designation,
                        PhoneNumber = createContact.PhoneNumber,
                        MobileNumber = createContact.MobileNumber,
                        EmailId = createContact.EmailId,
                        ContactStatus = createContact.ContactStatus,
                        ActionUser = createContact.ActionUser
                    }, commandType: CommandType.StoredProcedure);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response;

        }

        public async Task<ContactDetailDTO> Update(UpdateContact updateContact)
        {
            ContactDetailDTO response = new ContactDetailDTO();
            _logger.LogInformation($"Started updating Contact : " + updateContact.ContactId);
            try
            {
                using (SqlConnection connection = new SqlConnection(base.ConnectionString))
                {
                    response = await connection.QuerySingleAsync<ContactDetailDTO>(SP_ContactDetail_Update, new
                    {
                        ContactId = updateContact.ContactId,
                        MasterCode = updateContact.MasterCode,
                        PersonName = updateContact.PersonName,
                        Designation = updateContact.Designation,
                        PhoneNumber = updateContact.PhoneNumber,
                        MobileNumber = updateContact.MobileNumber,
                        EmailId = updateContact.EmailId,
                        ContactStatus = updateContact.ContactStatus,
                        ActionUser = updateContact.ActionUser
                    }, commandType: CommandType.StoredProcedure);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response;
        }

        public async Task<ContactDetailDTO> ReadById(int ContactId)
        {
            ContactDetailDTO response = new ContactDetailDTO();
            _logger.LogInformation($"Started reading Contact : " +ContactId);
            try
            {
                using (SqlConnection connection = new SqlConnection(base.ConnectionString))
                {
                    response = await connection.QuerySingleAsync<ContactDetailDTO>(SP_ContactDetail_ReadById, new
                    {
                        ContactId = ContactId,
                        
                    }, commandType: CommandType.StoredProcedure);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response;
        }

        public async Task<Unit> Delete(DeleteContact deleteContact)
        {
            _logger.LogInformation($"Started deleting Contact : " + deleteContact.ContactId);
            try
            {
                using (SqlConnection connection = new SqlConnection(base.ConnectionString))
                {
                    await connection.ExecuteAsync(
                        SP_ContactDetail_Delete,
                        new
                        {
                            ContactId = deleteContact.ContactId,
                            ActionUser = deleteContact.ActionUser
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

        public async Task<ContactList> ReadByMasterCode(string MasterCode)
        {
            ContactList response = new ContactList();
            _logger.LogInformation($"Started reading Contact by masterCode: " + MasterCode);
            try
            {
                using (SqlConnection connection = new SqlConnection(base.ConnectionString))
                {
                    response.Items = await connection.QueryAsync<ContactDetailDTO>(SP_ContactDetail_ReadByMasterCode, new
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

        public async Task<ContactDetailDTO> ReadByMasterCodeDefault(string MasterCode)
        {
            ContactDetailDTO response = new ContactDetailDTO();
            _logger.LogInformation($"Started reading Contact by masterCode: " + MasterCode);
            try
            {
                using (SqlConnection connection = new SqlConnection(base.ConnectionString))
                {
                    response = await connection.QuerySingleAsync<ContactDetailDTO>(SP_ContactDetail_ReadByMasterCodeDefault, new
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
    }
}
