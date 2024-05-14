using Application.DTOs.TBOS.Common;
using Application.DTOs.TBOS.Masters;
using Application.Interfaces.TBOS.Masters.Customer;
using Dapper;
using Domain.Settings;
using Infrastructure.Persistance.Services.TBOS.Masters.Branch;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistance.Services.TBOS.Masters.Customer
{
    public class CustomerMasterService : DABase, ICustomerMaster
    {
        APISettings _settings;
        private ILogger<CustomerMasterService> _logger;

        private const string SP_CustomerMaster_Insert = "master.CustomerMaster_Insert";
        private const string SP_CustomerMaster_Update = "master.CustomerMaster_Update";
        private const string SP_CustomerMaster_ReadAll = "master.CustomerMaster_ReadAll";
        private const string SP_CustomerMaster_ReadAllPaginated = "master.CustomerMaster_ReadAllPaginated";
        private const string SP_CustomerMaster_ReadByCustomerId = "master.CustomerMaster_ReadByCustomerId";
        private const string SP_CustomerMaster_Delete = "master.CustomerMaster_Delete";
       

        public CustomerMasterService(IOptions<ConnectionSettings> connectionSettings, ILogger<CustomerMasterService> logger, IOptions<APISettings> settings) : base(connectionSettings.Value.AppKeyPath)
        {
            _logger = logger;
            _settings = settings.Value;
        }

        public async Task<CustomerMasterDTO> Create(CreateCustomer createCustomer)
        {
            CustomerMasterDTO response = new CustomerMasterDTO();
            _logger.LogInformation($"Started creating Customer: {createCustomer.CustomerName} by User");
            try
            {
                using (SqlConnection connection = new SqlConnection(base.ConnectionString))
                {
                    response = await connection.QuerySingleAsync<CustomerMasterDTO>(SP_CustomerMaster_Insert, new
                    {
                        CustomerName = createCustomer.CustomerName,
                        TransportId = createCustomer.TransportId,
                        AgentId = createCustomer.AgentId,
                        PaymentTerm = createCustomer.PaymentTerm,
                        BranchId = createCustomer.BranchId,
                        CustomerBranch = createCustomer.CustomerBranch,
                        Status = createCustomer.Status,
                        TaxForm = createCustomer.TaxForm,
                        Tin_No = createCustomer.Tin_No,
                        AgentCommission = createCustomer.AgentCommission,
                        PaymentDay = createCustomer.PaymentDay,
                        CreditDaysLock = createCustomer.CreditDaysLock,
                        CstTinNo = createCustomer.CstTinNo,
                        CustomerType = createCustomer.CustomerType,
                        DefaultPrice = createCustomer.DefaultPrice,
                        DefaultInvoice = createCustomer.DefaultInvoice,
                        CreditAmountLock = createCustomer.CreditAmountLock,
                        PanNo = createCustomer.PanNo,
                        Priority = createCustomer.Priority,
                        CustomerRemarks = createCustomer.CustomerRemarks,
                        CGST = createCustomer.CGST,
                        SGST = createCustomer.SGST,
                        IGST = createCustomer.IGST,
                        UTGST = createCustomer.UTGST,
                        GSTIN_No = createCustomer.GSTIN_No,
                        GSTReverseCharge = createCustomer.GSTReverseCharge,
                        ExportGST = createCustomer.ExportGST,
                        ActionUser = createCustomer.ActionUser

                    }, commandType: CommandType.StoredProcedure);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response;
        }

        public async Task<CustomerMasterDTO> Update(UpdateCustomer updateCustomer)
        {
            CustomerMasterDTO response = new CustomerMasterDTO();
            _logger.LogInformation($"Started updating Customer: {updateCustomer.CustomerName} by User");
            try
            {
                using (SqlConnection connection = new SqlConnection(base.ConnectionString))
                {
                    response = await connection.QuerySingleAsync<CustomerMasterDTO>(SP_CustomerMaster_Update, new
                    {
                        CustomerId = updateCustomer.CustomerId,
                        CustomerName = updateCustomer.CustomerName,
                        TransportId = updateCustomer.TransportId,
                        AgentId = updateCustomer.AgentId,
                        PaymentTerm = updateCustomer.PaymentTerm,
                        BranchId = updateCustomer.BranchId,
                        CustomerBranch = updateCustomer.CustomerBranch,
                        Status = updateCustomer.Status,
                        TaxForm = updateCustomer.TaxForm,
                        Tin_No = updateCustomer.Tin_No,
                        AgentCommission = updateCustomer.AgentCommission,
                        PaymentDay = updateCustomer.PaymentDay,
                        CreditDaysLock = updateCustomer.CreditDaysLock,
                        CstTinNo = updateCustomer.CstTinNo,
                        CustomerType = updateCustomer.CustomerType,
                        DefaultPrice = updateCustomer.DefaultPrice,
                        DefaultInvoice = updateCustomer.DefaultInvoice,
                        CreditAmountLock = updateCustomer.CreditAmountLock,
                        PanNo = updateCustomer.PanNo,
                        Priority = updateCustomer.Priority,
                        CustomerRemarks = updateCustomer.CustomerRemarks,
                        CGST = updateCustomer.CGST,
                        SGST = updateCustomer.SGST,
                        IGST = updateCustomer.IGST,
                        UTGST = updateCustomer.UTGST,
                        GSTIN_No = updateCustomer.GSTIN_No,
                        GSTReverseCharge = updateCustomer.GSTReverseCharge,
                        ExportGST = updateCustomer.ExportGST,
                        ActionUser = updateCustomer.ActionUser

                    }, commandType: CommandType.StoredProcedure);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response;
        }
        public async Task<CustomerList> ReadAll()
        {
            CustomerList response = new CustomerList();
            _logger.LogInformation($"Started reading all Customers");
            try
            {
                using (SqlConnection connection = new SqlConnection(base.ConnectionString))
                {
                    response.Items = await connection.QueryAsync<CustomerMasterDTO>(SP_CustomerMaster_ReadAll, commandType: CommandType.StoredProcedure);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response;
        }


        public async Task<CustomerListPaginated> ReadAllPaginated(PaginatedDTO paginatedDTO)
        {
            CustomerListPaginated response = new CustomerListPaginated();
            _logger.LogInformation($"Started reading all Customers");
            try
            {
                using (SqlConnection connection = new SqlConnection(base.ConnectionString))
                {
                    response.Items = await connection.QueryAsync<CustomerMasterDTOPaginated>(SP_CustomerMaster_ReadAllPaginated, new
                    {
                        PageSize = paginatedDTO.PageSize,
                        PageNo = paginatedDTO.PageNo
                    }, commandType: CommandType.StoredProcedure);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response;
        }


        public async Task<CustomerMasterDTO> ReadByCustomerId(int CustomerId)
        {
            CustomerMasterDTO response = new CustomerMasterDTO();
            _logger.LogInformation($"Started reading all Customers");
            try
            {
                using (SqlConnection connection = new SqlConnection(base.ConnectionString))
                {
                    response = await connection.QuerySingleAsync<CustomerMasterDTO>(SP_CustomerMaster_ReadByCustomerId, new
                    {
                        CustomerId = CustomerId
                    } ,commandType: CommandType.StoredProcedure);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response;
        }

        public async Task<CustomerList> Delete(DeleteCustomer deleteCustomer)
        {
            CustomerList response = new CustomerList();
            _logger.LogInformation($"Started deleting Customer : {deleteCustomer.CustomerId}");
            try
            {
                using (SqlConnection connection = new SqlConnection(base.ConnectionString))
                {
                    response.Items = await connection.QueryAsync<CustomerMasterDTO>(SP_CustomerMaster_Delete, new
                    {
                        CustomerId = deleteCustomer.CustomerId,
                        ActionUser = deleteCustomer.ActionUser
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
