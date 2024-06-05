using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreManager : MonoBehaviour
{
    public static StoreManager Instance;
    public StoreInventory storeInventoryScript;

    public int i_itemCost;
    private int i_playerMoney;

    private void OnEnable()
    {
        Instance = this;
    }

    public void SetProductCostToPurchase(int productsCost)
    {
        i_itemCost = productsCost;
    }

    /// <summary>
    /// Make the purchase and substract the money
    /// </summary>
    /// <param name="cost"></param>
    public void PurchaseItemAndSubstractMoney()
    {
        i_playerMoney = Player.Instance.GetMoneyQuantity() - i_itemCost;
        Player.Instance.SetMoneyQuantity(i_playerMoney);
    }

    

    private void OnDisable()
    {
        Instance = null;
    }
}
