using Assets.Script.InventorySystem;

namespace Assets.Scripts.SelectObjectsSystem.Demo
{
    public class PlayerInteract // Test with Inventory system
    {
        private IItemSelector _itemSelector;
        private IInventory _inventory;

        public void InitInteractAction(IItemSelector itemSelector, IInventory inventory, UnityEngine.InputSystem.InputAction action)
        {
            _itemSelector = itemSelector;
            _inventory = inventory;

            action.performed += ctx => PerformInteract();
        }

        public void PerformInteract()
        {
            foreach (var item in _itemSelector.Selectables)
            {
                _inventory.AddItem(item.GetItem());
            }
        }
    }
}