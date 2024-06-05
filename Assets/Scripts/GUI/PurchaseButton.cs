using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseButton : MonoBehaviour
{

    /// <summary>
    /// Purchase your item
    /// </summary>
    public void PurchaseProduct()
    {
        Debug.Log("BUY");
        StoreManager.Instance.PurchaseItemAndSubstractMoney();
        StoreManager.Instance.storeInventoryScript.GiveProductToBag();
    }
}
