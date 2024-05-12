using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.TBOS.Common
{
    public class PaginatedDTO
    {
        public int? RowNo { get; set; }
        public int? TotalCount { get; set; }
        public int PageSize { get; set; }
        public int PageNo { get; set; }
    }
}
