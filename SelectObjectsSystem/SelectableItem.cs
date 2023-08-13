using Assets.Script.InventorySystem;
using UnityEngine;

namespace Assets.Scripts.SelectObjectsSystem
{
    public class SelectableItem : MonoBehaviour, ISelectableItem
    {
        [SerializeField] private Item _item;
        [SerializeField] private GameObject _shadowObject;


        public IItem GetItem()
        {
            return _item;
        }

        public void Deselect()
        {
            _shadowObject.SetActive(false);
        }

        public void Select()
        {
            _shadowObject.SetActive(true);
        }
    }
}