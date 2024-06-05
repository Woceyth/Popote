using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BagInventory : MonoBehaviour
{
    public int i_NumberOfProducts;
    public int i_bagIndex;
    public GameObject go_UIItem;
    public InventorySlot[] a_is_UIItem;
    public Transform t_parent;
    public EquippedGearInventory equippedGearInventory;

    // Start is called before the first frame update
    void Start()
    {
        a_is_UIItem = new InventorySlot[i_NumberOfProducts];
        CreateSlots();
    }

    private void CreateSlots()
    {
        for (int i = 0; i < i_NumberOfProducts; ++i)
        {
            // Make the list of the elements
            GameObject go_ListElement = Instantiate(go_UIItem, t_parent);
            InventorySlot pd_element = go_ListElement.transform.GetComponentInChildren<InventorySlot>();
            a_is_UIItem[i] = pd_element;
        }
    }

    public int ReturnClearestBagElement()
    {
        for (int i = 0; i < i_NumberOfProducts; ++i)
        {
            if (a_is_UIItem[i].product == null)
            {
                return i;
            }
        }
        return 0;
    }
}
