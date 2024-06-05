using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellButton : MonoBehaviour
{
    public BagInventory bagInventoryScript;

    /// <summary>
    /// Sell your item
    /// </summary>
    public void SellProduct()
    {
        Debug.Log("SELL");
        int i_indexToDelete = bagInventoryScript.i_swapIndex;
        InventoryManager.Instance.SellItemAndAddMoney();
        bagInventoryScript.a_is_UIItem[i_indexToDelete].product = null;
        bagInventoryScript.a_is_UIItem[i_indexToDelete].i_icon.sprite = null;
        bagInventoryScript.a_is_UIItem[i_indexToDelete].i_cost = 0;
    }
}
