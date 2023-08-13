using Assets.Script.InventorySystem;

namespace Assets.Scripts.SelectObjectsSystem
{
    public interface ISelectableItem
    {
        public void Select();
        public void Deselect();
        public IItem GetItem();
    }
}