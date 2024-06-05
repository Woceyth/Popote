using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquipButton : MonoBehaviour
{
    public InventorySlot is_bag_temp;
    public ProductData pd_equipped_temp;
    public BagInventory bagInventoryScript;
    public EquippedGearInventory equippedGearInventoryScript;

    /// <summary>
    /// Call the action to equip the clothe depending on the type
    /// </summary>
    public void EquipAction()
    {
        // Makes temporal values and indexes required to get the item type required to swap
        is_bag_temp = bagInventoryScript.a_is_UIItem[ bagInventoryScript.i_swapIndex ];
        int equippedTempIndex = GetItemIndexFromProductType(bagInventoryScript.a_is_UIItem[bagInventoryScript.i_swapIndex].product.type);
        pd_equipped_temp = equippedGearInventoryScript.a_pd_currenltyEquipped[equippedTempIndex];
        
        // Swaps and refresh the GUI depending if its the bag or the equipment
        SetValuesOnGUI(equippedGearInventoryScript.a_pd_currenltyEquipped[equippedTempIndex], equippedTempIndex, true );
        SetValuesOnGUI(bagInventoryScript.a_is_UIItem[bagInventoryScript.i_swapIndex].product, bagInventoryScript.i_swapIndex, false);
        
        // Release
        is_bag_temp = null;
        pd_equipped_temp = null;
    }

    private void SetValuesOnGUI(ProductData productData, int index, bool isbagORequipment)
    {
        if (isbagORequipment) 
        {
            // Equipment
            equippedGearInventoryScript.a_pd_currenltyEquipped[index] = is_bag_temp.product;
            equippedGearInventoryScript.a_pd_currenltyEquipped[index].icon = is_bag_temp.product.icon;
            equippedGearInventoryScript.a_pd_currenltyEquipped[index].cost = is_bag_temp.product.cost;
            equippedGearInventoryScript.l_equippedSlot[index].i_icon.sprite = is_bag_temp.product.icon;
            equippedGearInventoryScript.ChangePlayersClothes();
        }
        else
        {
            // Bag
            bagInventoryScript.a_is_UIItem[index].product = pd_equipped_temp;
            bagInventoryScript.a_is_UIItem[index].i_icon.sprite = pd_equipped_temp.icon;
            bagInventoryScript.a_is_UIItem[index].i_cost = pd_equipped_temp.cost;
        }
    }

    /// <summary>
    /// Get the index to equip depending on the type of item
    /// </summary>
    /// <param name="type"></param>
    /// <returns></returns>
    private int GetItemIndexFromProductType(int type)
    {
        switch (type)
        {
            default: // Head
            case 1:
                return 0;
            case 2: // Vest
                return 1;
            case 3: // Belt
                return 2;
            case 4: // Right hand
                return 3;
            case 5: // Left Hand
                return 4;
        }
    }
}
