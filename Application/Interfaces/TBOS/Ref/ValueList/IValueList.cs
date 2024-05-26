using Application.DTOs.TBOS.Ref.ValueList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.TBOS.Ref.ValueList
{
    public interface IValueList
    {
        public Task<ValueListDTO> Create(CreateValueList createValueList);
        public Task<ValueListDTO> Update(UpdateValueList updateValueList);
        public Task<ValueListAll> ReadAll();
    }
}
