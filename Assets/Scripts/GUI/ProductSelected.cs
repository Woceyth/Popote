using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class ProductSelected : MonoBehaviour
{
    public int i_itemIndex;
    public ProductData product;
    public GameObject go_iconFrame;
    public Image s_icon;
    public TextMeshProUGUI t_name;
    public TextMeshProUGUI t_description;
    public TextMeshProUGUI t_cost;
    public int i_cost;

    public StoreInventory si_script;
    public Button b_buyButton;

    /// <summary>
    /// When the player press the button it will communicate with the manager based on the selected product
    /// </summary>
    public void CommunicateWithManager()
    {
        Debug.Log("Pressed product button");
        si_script.DeselectEveryItem();
        go_iconFrame.SetActive(true);
        b_buyButton.interactable = true;
        StoreManager.Instance.storeInventoryScript.i_elementIndex = i_itemIndex;
        StoreManager.Instance.SetProductCostToPurchase(i_cost);
        //SetTextRed();
    }

    /// <summary>
    /// Sets every text to red color to show that a product has been bought
    /// </summary>
    private void SetTextRed()
    {
        t_name.color = Color.red;
        t_cost.color = Color.red;
        //t_description.color = Color.red;
    }

    public void DisableFrame()
    {
        Debug.Log("DisableFrame");
        go_iconFrame.SetActive(false);
    }
}
