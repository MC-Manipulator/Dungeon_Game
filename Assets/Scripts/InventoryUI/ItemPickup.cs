using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickUp : MonoBehaviour
{
    public Item Item;
    
    void Pickup(){
        InventoryManager.Instance.Add(Item);
        InventoryManager.Instance.ListItems();
        Destroy(gameObject);
    }

    private void OnMouseDown(){
        Pickup();
    }
}
