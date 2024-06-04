using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellButton : MonoBehaviour
{
    /// <summary>
    /// Sell your item
    /// </summary>
    public void PurchaseProduct()
    {
        Debug.Log("BUY");
        InventoryManager.Instance.SellItemAndAddMoney();
    }
}
