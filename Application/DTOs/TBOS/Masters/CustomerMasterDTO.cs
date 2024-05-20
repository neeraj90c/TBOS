using Application.DTOs.TBOS.Common;
using Application.Features.TBOS.Masters.Customer;
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
        public int TransportId { get; set; }
        public int? AgentId { get; set; }
        public int? PaymentTerm { get; set; }
        public int? BranchId { get; set; }
        public string CustomerBranch { get; set; }
        public int? Status { get; set; }
        public string TaxForm { get; set; }
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
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int IsActive { get; set; }
        public int IsDeleted { get; set; }

    }
    public class CustomerMasterDTOPaginated : PaginatedDTO
    {
        public int CustomerId { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public int TransportId { get; set; }
        public int? AgentId { get; set; }
        public int? PaymentTerm { get; set; }
        public int? BranchId { get; set; }
        public string CustomerBranch { get; set; }
        public int? Status { get; set; }
        public string TaxForm { get; set; }
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
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int IsActive { get; set; }
        public int IsDeleted { get; set; }
        public int DetailId { get; set; }
        public string MasterCode { get; set; }
        public string AddressType { get; set; }
        public string Add_line1 { get; set; }
        public string Add_line2 { get; set; }
        public string Add_line3 { get; set; }
        public string Add_line4 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Pincode { get; set; }
        public int? AddressStatus { get; set; }
        public int? ContactId { get; set; }
        public string? PersonName { get; set; }
        public string? Designation { get; set; }
        public string? PhoneNumber { get; set; }
        public string? MobileNumber { get; set; }
        public string? EmailId { get; set; }
        public int? ContactStatus { get; set; }
        public string? AgentName {  get; set; }
        public string? TransportName {  get; set; }
    }


    public class CreateCustomer
    {
        public string CustomerName { get; set; }
        public int TransportId { get; set; }
        public int? AgentId { get; set; }
        public int PaymentTerm { get; set; }
        public int BranchId { get; set; }
        public string CustomerBranch { get; set; }
        public int Status { get; set; }
        public string TaxForm { get; set; }
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
        public string CustomerName { get; set; }
        public int TransportId { get; set; }
        public int AgentId { get; set; }
        public int PaymentTerm { get; set; }
        public int BranchId { get; set; }
        public string CustomerBranch { get; set; }
        public int Status { get; set; }
        public string TaxForm { get; set; }
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

    public class DeleteCustomer
    {
        public int CustomerId { get; set; }
        public string ActionUser { get; set; }
    }
    public class CustomerList
    {
        public IEnumerable<CustomerMasterDTO> Items { get; set; }
    }
    public class CustomerListPaginated
    {
        public IEnumerable<CustomerMasterDTOPaginated> Items { get; set; }
    }
}
