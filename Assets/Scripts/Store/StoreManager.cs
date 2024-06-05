using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StoreManager : MonoBehaviour
{
    public static StoreManager Instance;
    public StoreInventory storeInventoryScript;
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
    public void SetProductCostToPurchase(int productsCost)
    {
        i_itemCost = productsCost;
    }

    /// <summary>
    /// Check if the player can purchase this product
    /// </summary>
    /// <param name="productsCost"></param>
    /// <returns></returns>
    public bool QuestionIfAffordable(int productsCost)
    {
        if(Player.Instance.GetMoneyQuantity() < productsCost)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    /// <summary>
    /// Make the purchase and substract the money, then update the gui
    /// </summary>
    /// <param name="cost"></param>
    public void PurchaseItemAndSubstractMoney()
    {
        i_playerMoney = Player.Instance.GetMoneyQuantity() - i_itemCost;
        Player.Instance.SetMoneyQuantity(i_playerMoney);

        if (Player.Instance.GetMoneyQuantity() < 0)
        {
            Player.Instance.SetMoneyQuantity(0);
        }
        tmp_conQuantityText.text = Player.Instance.GetMoneyQuantity().ToString();
    }

    

    private void OnDisable()
    {
        Instance = null;
    }
}
