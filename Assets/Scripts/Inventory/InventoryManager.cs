using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;

    public int i_itemCost;
    private int i_playerMoney;

    private void OnEnable()
    {
        Instance = this;
    }

    public void SetProductCostToSell(int productsCost)
    {
        i_itemCost = productsCost;
    }

    /// <summary>
    /// Sell a product and add money
    /// </summary>
    public void SellItemAndAddMoney()
    {
        i_playerMoney = Player.Instance.GetMoneyQuantity() + i_itemCost;
        Player.Instance.SetMoneyQuantity(i_playerMoney);
    }

    private void OnDisable()
    {
        Instance = null;
    }
}
