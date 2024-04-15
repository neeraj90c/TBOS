﻿using Application.DTOs.SupportDesk;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.LeadGeneration
{
    public class SalesLeadDTO
    {
        public long LeadId { get; set; }
        public int ProjectId { get; set; }
        public string PName { get; set; }
        public int CompanyId { get; set; }
        public string CName { get; set; }
        public string LTitle { get; set; }
        public string LDesc { get; set; }
        public string Category { get; set; }
        public string TagList { get; set; }
        public string AssignedToName { get; set; }
        public string LeadOwner { get; set; }
        public string LeadStatus { get; set; }
        public string LeadPriority { get; set; }
        public DateTime LeadDate { get; set; }
        public DateTime NextFollowUpDate { get; set; }
        public string AddField1 { get; set; }
        public string AddField2 { get; set; }
        public string AddField3 { get; set; }
        public int IsActive { get; set; }
        public int IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string ActionUser { get; set; }
        public string ?CreatedByName {  get; set; }
        public string ?CompanyCode {  get; set; }
        public string ?ConName { get; set; }
        public string ?CNumber { get; set; }
        public string ?CEmail { get; set; }
        public string ?CDesignation { get; set; }
        public string ?Address { get; set; }
    }

    // LeadActivity DTO
    public class LeadActivityDTO
    {
        public long LeadActivityId { get; set; }
        public long LeadId { get; set; }
        public string LeadComments { get; set; }
        public int IsActive { get; set; }
        public int IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ActionUser { get; set; }

    }

    // LeadAsignee DTO
    public class LeadAsigneeDTO
    {
        public long LAId { get; set; }
        public long LeadId { get; set; }
        public string AssignedTo { get; set; }
        public string ADesc { get; set; }
        public string AStatus { get; set; }
        public int IsActive { get; set; }
        public int IsDeleted { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedOn { get; set; }
        public int ActionUser { get; set; }

    }

    public class AssignLeadDTO
    {
        public int? LAid { get; set; }
        public int LeadId { get; set; }
        public string AssignedTo { get; set; }
        public string ADesc { get; set; }
        public string AStatus { get; set; }
        public int ActionUser { get; set; }
    }


    public class SalesLeadList
    {
        public IEnumerable<SalesLeadDTO> NewAndOpen { get; set; }
        public IEnumerable<SalesLeadDTO> InProgress { get; set; }
        public IEnumerable<SalesLeadDTO> Closed { get; set; }
        public IEnumerable<SalesLeadDTO> Success { get; set; }
    }

    public class GetWorkListDTO
    {
        public int ActionUser { get; set; }
	    public int CompanyId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }

    public class LeadWorkList
    {
        public IEnumerable<SalesLeadDTO> WorkInProgress { get; set; }
        public IEnumerable<SalesLeadDTO> AssignedToMe { get; set; }
        public IEnumerable<SalesLeadDTO> OpenLeads { get; set; }
        public IEnumerable<SalesLeadDTO> ClosedLeads { get; set; }
        public IEnumerable<SalesLeadDTO> AssignedToOthers { get; set; }
        public IEnumerable<SalesLeadDTO> Success { get; set; }

    }
    public class LeadActivityList
    {
        public IEnumerable<LeadActivityDTO> Items { get; set; }
    }
    public class LeadAsigneeList
    {
        public IEnumerable<LeadAsigneeDTO> Items { get; set; }
    }



    public class CreateActivityDTO
    {
        public int LeadId { get; set; }
        public string LeadComments { get; set; }
        public int ActionUser { get; set; }
    }

    public class UpdateActivityDTO
    {
        public int LeadActivityId { get; set; }
        public int LeadId { get; set; }
        public string LeadComments { get; set; }
        public int ActionUser { get; set; }
    }
    public class DeleteActivityDTO
    {
        public int LeadActivityId { get; set; }
        public int ActionUser { get; set; }
    }


    public class GetAllSalesLeadByUserIdDTO
    {
        public int ActionUser { get; set; }
        public int CompanyId { get; set; }
    }

    public class LeadResolverDTO
    {
        public string Name { get; set; }
        public int UserId { get; set; }
    }

    public class LeadResolverList
    {
        public IEnumerable<LeadResolverDTO> Items {  get; set; }
    }

    public class DaybookLeadList
    {
        public IEnumerable<SalesLeadDTO> FreshLeads { get; set; }
        public IEnumerable<SalesLeadDTO> FollowUp { get; set; }
    }


}
