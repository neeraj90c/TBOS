using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.TBOS.Masters
{
    public class CustomerMasterDTO
    {
        public int CustomerId { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string Transport { get; set; }
        public string AgentId { get; set; }
        public int? PaymentTerm { get; set; }
        public int? BranchId { get; set; }
        public string CustomerBranch { get; set; }
        public int? Status { get; set; }
        public string TaxFrom { get; set; }
        public string Tin_No { get; set; }
        public float? AgentCommission { get; set; }
        public string PaymentDay { get; set; }
        public int? CreditDaysLock { get; set; }
        public string CstTinNo { get; set; }
        public string CustomerType { get; set; }
        public string DefaultPrice { get; set; }
        public string DefaultInvoice { get; set; }
        public float? CreditAmountLock { get; set; }
        public string PanNo { get; set; }
        public string Priority { get; set; }
        public string CustomerRemarks { get; set; }
        public string CGST { get; set; }
        public string SGST { get; set; }
        public string IGST { get; set; }
        public string UTGST { get; set; }
        public string GSTIN_No { get; set; }
        public string GSTReverseCharge { get; set; }
        public string ExportGST { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string MdifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
    }


    public class CreateCustomer
    {
        public string CustomerName { get; set; }
        public string Transport { get; set; }
        public string AgentId { get; set; }
        public int PaymentTerm { get; set; }
        public int BranchId { get; set; }
        public string CustomerBranch { get; set; }
        public int Status { get; set; }
        public string TaxFrom { get; set; }
        public string Tin_No { get; set; }
        public decimal AgentCommission { get; set; }
        public string PaymentDay { get; set; }
        public int CreditDaysLock { get; set; }
        public string CstTinNo { get; set; }
        public string CustomerType { get; set; }
        public string DefaultPrice { get; set; }
        public string DefaultInvoice { get; set; }
        public decimal CreditAmountLock { get; set; }
        public string PanNo { get; set; }
        public string Priority { get; set; }
        public string CustomerRemarks { get; set; }
        public string CGST { get; set; }
        public string SGST { get; set; }
        public string IGST { get; set; }
        public string UTGST { get; set; }
        public string GSTIN_No { get; set; }
        public string GSTReverseCharge { get; set; }
        public string ExportGST { get; set; }
        public string ActionUser { get; set; }
    }

    public class UpdateCustomer
    {
        public int CustomerId { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string Transport { get; set; }
        public string AgentId { get; set; }
        public int PaymentTerm { get; set; }
        public int BranchId { get; set; }
        public string CustomerBranch { get; set; }
        public int Status { get; set; }
        public string TaxFrom { get; set; }
        public string Tin_No { get; set; }
        public float? AgentCommission { get; set; }
        public string PaymentDay { get; set; }
        public int CreditDaysLock { get; set; }
        public string CstTinNo { get; set; }
        public string CustomerType { get; set; }
        public string DefaultPrice { get; set; }
        public string DefaultInvoice { get; set; }
        public decimal CreditAmountLock { get; set; }
        public string PanNo { get; set; }
        public string Priority { get; set; }
        public string CustomerRemarks { get; set; }
        public string CGST { get; set; }
        public string SGST { get; set; }
        public string IGST { get; set; }
        public string UTGST { get; set; }
        public string GSTIN_No { get; set; }
        public string GSTReverseCharge { get; set; }
        public string ExportGST { get; set; }
        public string ActionUser { get; set; }
    }

}
