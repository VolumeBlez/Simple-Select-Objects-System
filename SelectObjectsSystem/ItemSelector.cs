using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts.SelectObjectsSystem
{
    [RequireComponent(typeof(CircleCollider2D))]
    public class ItemSelector : MonoBehaviour, IItemSelector
    {
        private List<ISelectableItem> _selectableItems = new();
        private CircleCollider2D _collider;
        private float _radiusCircleCollider;

        public IEnumerable<ISelectableItem> Selectables => _selectableItems;

        public void Init(float selectRadius)
        {
            _collider = GetComponent<CircleCollider2D>();
            _collider.radius = selectRadius;
        }


        private void OnTriggerEnter2D(Collider2D other)
        {
            if (other.TryGetComponent(out ISelectableItem selectable))
            {
                selectable.Select();
                _selectableItems.Add(selectable);
            }
        }

        private void OnTriggerExit2D(Collider2D other)
        {
            if (other.TryGetComponent(out ISelectableItem selectable))
            {
                selectable.Deselect();
                _selectableItems.Remove(selectable);
            }
        }
    }
}