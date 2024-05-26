using Application.DTOs.TBOS.Ref.ValueList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces.TBOS.Ref.ValueListItem
{
    public interface IValueListItem
    {
        public Task<ValueListItemDTO> Create(CreateValueListItem createValueListItem);
        public Task<ValueListItemDTO> Update(UpdateValueListItem updateValueListItem);
        public Task<ValueListItemAll> ReadByValueListId(int ValuesListId);
        public Task<ValueListItemAll> ReadByVLName(string vlName);

    }
}
