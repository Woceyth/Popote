using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreInventory : MonoBehaviour
{
    public int i_NumberOfProducts;
    public int i_elementIndex;
    public Button b_buyButton;
    public GameObject go_UIItem;
    public ProductData[] a_pd_UIItem;
    public List<ProductSelected> l_productList;
    public Transform t_parent;
    public BagInventory bagInventoryScript;

    // Start is called before the first frame update
    void Start()
    {
        CreateCatalogue();
    }

    /// <summary>
    /// Create catalogue for the store
    /// </summary>
    private void CreateCatalogue()
    {
        for( int i = 0; i < i_NumberOfProducts; ++i)
        {
            // Make a random list of the elements
            int i_randomIndex = UnityEngine.Random.Range(0, a_pd_UIItem.Length);
            GameObject go_ListElement = Instantiate(go_UIItem, t_parent);

            // Set the products details to the store listing
            ProductSelected ps_element = go_ListElement.GetComponent<ProductSelected>();
            ps_element.product = a_pd_UIItem[i_randomIndex];
            ps_element.i_itemIndex = i;
            ps_element.t_name.text = a_pd_UIItem[i_randomIndex].name;
            ps_element.t_cost.text = a_pd_UIItem[i_randomIndex].cost.ToString();
            ps_element.i_cost = a_pd_UIItem[i_randomIndex].cost;
            ps_element.s_icon.sprite = a_pd_UIItem[i_randomIndex].icon;
            ps_element.b_buyButton = b_buyButton;
            ps_element.si_script = this;
            l_productList.Add(ps_element);
        }
    }

    /// <summary>
    /// Give the purchased product to the inventory bag
    /// </summary>
    public void GiveProductToBag()
    {
        int freeIndex = bagInventoryScript.ReturnClearestBagElement();
        bagInventoryScript.a_is_UIItem[ freeIndex ].product = l_productList[i_elementIndex].product;

        // Fill the information in the ui
        //bagInventoryScript.a_is_UIItem[freeIndex].name = bagInventoryScript.a_is_UIItem[freeIndex].product.name;
        bagInventoryScript.a_is_UIItem[freeIndex].i_icon.sprite = bagInventoryScript.a_is_UIItem[freeIndex].product.icon;

        // remove element from the list
        //Destroy(l_productList[i_elementIndex].gameObject);
        l_productList[i_elementIndex].gameObject.SetActive(false);
        l_productList.RemoveAt(i_elementIndex);
        i_NumberOfProducts--;
    }


    /// <summary>
    /// Deselect Every item
    /// </summary>
    public void DeselectEveryItem()
    {
        for (int i = 0; i < i_NumberOfProducts; ++i)
        {
            l_productList[i].DisableFrame();
        }
    }
}
