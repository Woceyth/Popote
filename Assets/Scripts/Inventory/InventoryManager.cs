using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;
    public TextMeshProUGUI tmp_conQuantityText;

    public int i_itemCost;
    private int i_playerMoney;

    private void OnEnable()
    {
        Instance = this;
    }

    /// <summary>
    /// Set the product cost
    /// </summary>
    /// <param name="productsCost"></param>
    public void SetProductCostToSell(int productsCost)
    {
        i_itemCost = productsCost;
    }

    /// <summary>
    /// Sell a product and add money, then update the gui
    /// </summary>
    public void SellItemAndAddMoney()
    {
        i_playerMoney = Player.Instance.GetMoneyQuantity() + i_itemCost;
        Player.Instance.SetMoneyQuantity(i_playerMoney);
        tmp_conQuantityText.text = Player.Instance.GetMoneyQuantity().ToString();
    }

    private void OnDisable()
    {
        Instance = null;
    }
}
