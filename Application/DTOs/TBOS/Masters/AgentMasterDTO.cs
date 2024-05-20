using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.TBOS.Masters
{
    public class AgentMasterDTO
    {
        public int AgentId { get; set; }
        public string AgentName { get; set; }
        public int? AgentStatus { get; set; }
        public string PanNo { get; set; }
        public string Zone { get; set; }
        public decimal? AgentCommission { get; set; }
        public string BranchId { get; set; }
        public string CGST { get; set; }
        public string SGST { get; set; }
        public string IGST { get; set; }
        public string UTGST { get; set; }
        public string GSTIN_No { get; set; }
        public string GSTReverseCharge { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? IsActive { get; set; }
        public int? IsDeleted { get; set; }
    }

    public class AgentList
    {
        public IEnumerable<AgentMasterDTO> Items { get; set; }
    }

    public class CreateAgent
    {
        public string AgentName { get; set; }
        public int? AgentStatus { get; set; }
        public string PanNo { get; set; }
        public string Zone { get; set; }
        public decimal? AgentCommission { get; set; }
        public string BranchId { get; set; }
        public string CGST { get; set; }
        public string SGST { get; set; }
        public string IGST { get; set; }
        public string UTGST { get; set; }
        public string GSTIN_No { get; set; }
        public string GSTReverseCharge { get; set; }
        public string ActionUser { get; set; }

    }

    public class UpdateAgent
    {
        public int AgentId { get; set; }
        public string AgentName { get; set; }
        public int? AgentStatus { get; set; }
        public string PanNo { get; set; }
        public string Zone { get; set; }
        public decimal? AgentCommission { get; set; }
        public string BranchId { get; set; }
        public string CGST { get; set; }
        public string SGST { get; set; }
        public string IGST { get; set; }
        public string UTGST { get; set; }
        public string GSTIN_No { get; set; }
        public string GSTReverseCharge { get; set; }
        public string ActionUser { get; set ; }

    }

    public class DeleteAgent
    {
        public int AgentId { get; set; }
        public string ActionUser { get; set ; }
    }
}
