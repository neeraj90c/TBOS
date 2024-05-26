using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.TBOS.Ref.ValueList
{
    public class ValueListDTO
    {
        public int ValueListId { get; set; }
        public string vlName { get; set; }
        public string vlCode { get; set; }
        public string vlDesc { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedOn { get; set; }
        public int? IsActive { get; set; }
        public int? IsDeleted { get; set; }
    }

    public class ValueListAll
    {
        public IEnumerable<ValueListDTO> Items { get; set; }
    }

    public class CreateValueList
    {
        public string vlName { get; set; }
        public string? vlCode { get; set; }
        public string? vlDesc { get; set; }
        public string ActionUser { get; set; }

    }

    public class UpdateValueList
    {
        public int ValueListId { get; set; }
        public string vlName { get; set; }
        public string? vlCode { get; set; }
        public string? vlDesc { get; set; }
        public string ActionUser { get; set; }
    }
}
