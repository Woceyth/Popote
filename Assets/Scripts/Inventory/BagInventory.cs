using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BagInventory : MonoBehaviour
{
    public int i_NumberOfProducts;
    public int i_bagIndex;
    public int i_swapIndex;
    public GameObject go_UIItem;
    public InventorySlot[] a_is_UIItem;
    public Transform t_parent;
    public EquippedGearInventory equippedGearInventory;

    [Header("Interactable Button")]
    public Button equipButton;
    public Button sellButton;

    // Start is called before the first frame update
    void Start()
    {
        a_is_UIItem = new InventorySlot[i_NumberOfProducts];
        CreateSlots();
    }

    /// <summary>
    /// Creates all slots the player can store
    /// </summary>
    private void CreateSlots()
    {
        for (int i = 0; i < i_NumberOfProducts; ++i)
        {
            // Make the list of the elements
            GameObject go_ListElement = Instantiate(go_UIItem, t_parent);
            InventorySlot is_element = go_ListElement.transform.GetComponentInChildren<InventorySlot>();
            InventorySelected is_button = go_ListElement.GetComponent<InventorySelected>();
            is_button.is_inventorySlotScript = is_element;
            is_button.bi_bagInventoryParent = this;
            is_button.equipButton = equipButton;
            is_button.sellButton = sellButton;
            is_element.i_index = i;
            a_is_UIItem[i] = is_element;
        }
    }

    /// <summary>
    /// Return a clear index from the array InventorySlot[] a_is_UIItem
    /// </summary>
    /// <returns></returns>
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
