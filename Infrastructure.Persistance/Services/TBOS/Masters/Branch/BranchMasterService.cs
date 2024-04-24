using Application.DTOs.SupportDesk;
using Application.DTOs.TBOS.Masters;
using Application.Interfaces.TBOS.Masters.Branch;
using Dapper;
using Domain.Settings;
using Infrastructure.Persistance.Services.SupportDesk;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Persistance.Services.TBOS.Masters.Branch
{
    public class BranchMasterService :DABase, IBranchMaster
    {
        APISettings _settings;
        private ILogger<BranchMasterService> _logger;
        private const string SP_BranchMaster_Insert = "master.BranchMaster_Insert";
        private const string SP_BranchMaster_ReadByCompanyId = "master.BranchMaster_ReadByCompanyId";
        private const string SP_BranchMaster_ReadById = "master.BranchMaster_ReadById";
        private const string SP_BranchMaster_Update = "master.BranchMaster_Update";



        public BranchMasterService(IOptions<ConnectionSettings> connectionSettings, ILogger<BranchMasterService> logger, IOptions<APISettings> settings) : base(connectionSettings.Value.AppKeyPath)
        {
            _logger = logger;
            _settings = settings.Value;
        }


        public async Task<BranchMasterDTO> Create(CreateBranch createBranch)
        {
            BranchMasterDTO response = new BranchMasterDTO();
            _logger.LogInformation($"Started creating Branch: {createBranch.BranchName} by User");
            try
            {
                using (SqlConnection connection = new SqlConnection(base.ConnectionString))
                {
                    response = await connection.QuerySingleAsync<BranchMasterDTO>(SP_BranchMaster_Insert, new
                    {
                        BranchName = createBranch.BranchName,
                        Specialization = createBranch.Specialization,
                        Tin_No = createBranch.Tin_No,
                        Tin_Date = createBranch.Tin_Date,
                        Website = createBranch.Website,
                        BankAccountName = createBranch.BankAccountName,
                        BankAccountNo = createBranch.BankAccountNo,
                        BankName = createBranch.BankName,
                        BankBranchName = createBranch.BankBranchName,
                        Bank_RTGS_NEFT_IFSC_code = createBranch.Bank_RTGS_NEFT_IFSC_code,
                        EmailId = createBranch.EmailId,
                        EmailPassword = createBranch.EmailPassword,
                        CompanyProfile = createBranch.CompanyProfile,
                        InvoiceHeaderHtml = createBranch.InvoiceHeaderHtml,
                        PackingSlipHeaderHtml = createBranch.PackingSlipHeaderHtml,
                        CreditNoteHeaderHtml = createBranch.CreditNoteHeaderHtml,
                        DebitNoteHeaderHtml = createBranch.DebitNoteHeaderHtml,
                        SmtpAddress = createBranch.SmtpAddress,
                        SmtpPort = createBranch.SmtpPort,
                        CstTinNo = createBranch.CstTinNo,
                        OrderHeaderHtml = createBranch.OrderHeaderHtml,
                        smsAPIkey = createBranch.smsAPIkey,
                        smsSenderId = createBranch.smsSenderId,
                        BrandName = createBranch.BrandName,
                        IsDefaultBranch = createBranch.IsDefaultBranch,
                        BranchType = createBranch.BranchType,
                        Latitude = createBranch.Latitude,
                        Longitude = createBranch.Longitude,
                        ExciseNo = createBranch.ExciseNo,
                        PanNo = createBranch.PanNo,
                        GstTinNo = createBranch.GstTinNo,
                        ActionUser = createBranch.ActionUser,
                        CompanyId = createBranch.CompanyId
                    }, commandType: CommandType.StoredProcedure);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response;
        }
        public async Task<BranchList> ReadByCompanyId(int CompanyId)
        {
            BranchList response = new BranchList();
            _logger.LogInformation($"Started reading Branch By CompanyId: {CompanyId} by User");
            try
            {
                using (SqlConnection connection = new SqlConnection(base.ConnectionString))
                {
                    response.Items = await connection.QueryAsync<BranchMasterDTO>(SP_BranchMaster_ReadByCompanyId, new
                    {
                        CompanyId = CompanyId
                    }, commandType: CommandType.StoredProcedure);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response;
        }

        public async Task<BranchMasterDTO> ReadById(int BranchId)
        {
            BranchMasterDTO response = new BranchMasterDTO();
            _logger.LogInformation($"Started Fetching Branch Detail: {BranchId} by User");

            try
            {
                using (SqlConnection connection = new SqlConnection(base.ConnectionString))
                {
                    response = await connection.QuerySingleAsync<BranchMasterDTO>(SP_BranchMaster_ReadById, new
                    {
                        BranchId = BranchId
                    }, commandType: CommandType.StoredProcedure);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return response;
        }

        public async Task<BranchMasterDTO> Update(UpdateBranch updateBranch)
        {
            BranchMasterDTO response = new BranchMasterDTO();
            _logger.LogInformation($"Started Updating Branch Detail: {updateBranch.BranchId} by User");

            try
            {
                using (SqlConnection connection = new SqlConnection(base.ConnectionString))
                {
                    response = await connection.QuerySingleAsync<BranchMasterDTO>(SP_BranchMaster_Update, new
                    {
                        BranchId = updateBranch.BranchId,
                        BranchName = updateBranch.BranchName,
                        Specialization = updateBranch.Specialization,
                        Tin_No = updateBranch.Tin_No,
                        Tin_Date = updateBranch.Tin_Date,
                        Website = updateBranch.Website,
                        BankAccountName = updateBranch.BankAccountName,
                        BankAccountNo = updateBranch.BankAccountNo,
                        BankName =  updateBranch.BankName,
                        BankBranchName =  updateBranch.BankBranchName,
                        Bank_RTGS_NEFT_IFSC_code = updateBranch.Bank_RTGS_NEFT_IFSC_code,
                        EmailId = updateBranch.EmailId,
                        EmailPassword = updateBranch.EmailPassword,
                        CompanyProfile =    updateBranch.CompanyProfile,
                        InvoiceHeaderHtml =   updateBranch.InvoiceHeaderHtml,
                        PackingSlipHeaderHtml = updateBranch.PackingSlipHeaderHtml,
                        CreditNoteHeaderHtml =updateBranch.CreditNoteHeaderHtml,
                        DebitNoteHeaderHtml = updateBranch.DebitNoteHeaderHtml,
                        SmtpAddress = updateBranch.SmtpAddress,
                        SmtpPort = updateBranch.SmtpPort,
                        CstTinNo = updateBranch.CstTinNo,
                        OrderHeaderHtml = updateBranch.OrderHeaderHtml,
                        smsSenderId = updateBranch.smsSenderId,
                        BrandName = updateBranch.BrandName,
                        BranchType = updateBranch.BranchType,
                        Latitude = updateBranch.Latitude,
                        Longitude = updateBranch.Longitude,
                        ExciseNo = updateBranch.ExciseNo,
                        PanNo = updateBranch.PanNo,
                        GstTinNo = updateBranch.GstTinNo,
                        IsDefaultBranch = updateBranch.IsDefaultBranch,
                        CompanyId = updateBranch.CompanyId,
                        ActionUser = updateBranch.ActionUser
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
