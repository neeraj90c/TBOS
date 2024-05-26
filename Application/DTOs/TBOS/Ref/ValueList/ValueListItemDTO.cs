using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.TBOS.Ref.ValueList
{
    public class ValueListItemDTO
    {
        public int ValueListItemId { get; set; }
        public int ValuesListId { get; set; }
        public string vliName { get; set; }
        public string vliCode { get; set; }
        public string vliDesc { get; set; }
        public int displaySeq { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? IsActive { get; set; }
        public int? IsDeleted { get; set; }
    }

    public class ValueListItemAll
    {
        public IEnumerable<ValueListItemDTO> Items { get; set; }
    }

    public class CreateValueListItem
    {
        public int ValuesListId { get; set; }
        public string vliName { get; set; }
        public string vliCode { get; set; }
        public string vliDesc { get; set; }
        public int displaySeq { get; set; }
        public string ActionUser { get; set; }

    }

    public class UpdateValueListItem
    {
        public int ValueListItemId { get; set; }
        public int ValuesListId { get; set; }
        public string vliName { get; set; }
        public string vliCode { get; set; }
        public string vliDesc { get; set; }
        public int displaySeq { get; set; }
        public string ActionUser { get; set; }

    }
}
