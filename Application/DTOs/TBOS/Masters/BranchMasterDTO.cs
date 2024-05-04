using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.TBOS.Masters
{
    public class BranchMasterDTO
    {
        public long BranchId { get; set; }
        public string BranchCode { get; set; }
        public string BranchName { get; set; }
        public string Specialization { get; set; }
        public string Tin_No { get; set; }
        public string Tin_Date { get; set; }
        public string Website { get; set; }
        public string BankAccountName { get; set; }
        public string BankAccountNo { get; set; }
        public string BankName { get; set; }
        public string BankBranchName { get; set; }
        public string Bank_RTGS_NEFT_IFSC_code { get; set; }
        public string EmailId { get; set; }
        public string EmailPassword { get; set; }
        public string CompanyProfile { get; set; }
        public string InvoiceHeaderHtml { get; set; }
        public string PackingSlipHeaderHtml { get; set; }
        public string CreditNoteHeaderHtml { get; set; }
        public string DebitNoteHeaderHtml { get; set; }
        public string SmtpAddress { get; set; }
        public int? SmtpPort { get; set; }
        public string CstTinNo { get; set; }
        public string OrderHeaderHtml { get; set; }
        public string smsAPIkey { get; set; }
        public string smsSenderId { get; set; }
        public string BrandName { get; set; }
        public string BranchType { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string ExciseNo { get; set; }
        public string PanNo { get; set; }
        public string GSTIN_No { get; set; }
        public int? IsDefaultBranch { get; set; }
        public string CompanyId { get; set; }
        public int IsActive { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int IsDeleted { get; set; }
    }

    public class BranchList
    {
        public IEnumerable<BranchMasterDTO> Items { get; set; }
    }

    public class CreateBranch
    {
        public string BranchName { get; set; }
        public string Specialization { get; set; }
        public string Tin_No { get; set; }
        public DateTime Tin_Date { get; set; }
        public string Website { get; set; }
        public string BankAccountName { get; set; }
        public string BankAccountNo { get; set; }
        public string BankName { get; set; }
        public string BankBranchName { get; set; }
        public string Bank_RTGS_NEFT_IFSC_code { get; set; }
        public string EmailId { get; set; }
        public string EmailPassword { get; set; }
        public string CompanyProfile { get; set; }
        public string InvoiceHeaderHtml { get; set; }
        public string PackingSlipHeaderHtml { get; set; }
        public string CreditNoteHeaderHtml { get; set; }
        public string DebitNoteHeaderHtml { get; set; }
        public string SmtpAddress { get; set; }
        public int SmtpPort { get; set; }
        public string CstTinNo { get; set; }
        public string OrderHeaderHtml { get; set; }
        public string smsAPIkey { get; set; }
        public string smsSenderId { get; set; }
        public string BrandName { get; set; }
        public int IsDefaultBranch { get; set; }
        public string BranchType { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string ExciseNo { get; set; }
        public string PanNo { get; set; }
        public string GSTIN_No { get; set; }
        public string ActionUser { get; set; }
        public string CompanyId { get; set; }
    }

    public class UpdateBranch
    {
        public int BranchId { get; set; }
        public string BranchName { get; set; }
        public string Specialization { get; set; }
        public string Tin_No { get; set; }
        public string Tin_Date { get; set; }
        public string Website { get; set; }
        public string BankAccountName { get; set; }
        public string BankAccountNo { get; set; }
        public string BankName { get; set; }
        public string BankBranchName { get; set; }
        public string Bank_RTGS_NEFT_IFSC_code { get; set; }
        public string EmailId { get; set; }
        public string EmailPassword { get; set; }
        public string CompanyProfile { get; set; }
        public string InvoiceHeaderHtml { get; set; }
        public string PackingSlipHeaderHtml { get; set; }
        public string CreditNoteHeaderHtml { get; set; }
        public string DebitNoteHeaderHtml { get; set; }
        public string SmtpAddress { get; set; }
        public int SmtpPort { get; set; }
        public string CstTinNo { get; set; }
        public string OrderHeaderHtml { get; set; }
        public string smsSenderId { get; set; }
        public string BrandName { get; set; }
        public string BranchType { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string ExciseNo { get; set; }
        public string PanNo { get; set; }
        public string GSTIN_No { get; set; }
        public int IsDefaultBranch { get; set; }
        public string CompanyId { get; set; }
        public string ActionUser { get; set; }
    }

}
