using System.Collections.Generic;

namespace Assets.Scripts.SelectObjectsSystem
{
    public interface IItemSelector
    {
        public IEnumerable<ISelectableItem> Selectables { get; }
    }
}