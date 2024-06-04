using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreInventory : MonoBehaviour
{
    public int i_NumberOfProducts;
    public Button b_buyButton;
    public GameObject go_UIItem;
    public ProductData[] a_pd_UIItem;
    public List<ProductSelected> l_productList;
    public Transform t_parent;

    // Start is called before the first frame update
    void Start()
    {
        CreateCatalogue();
    }

    /// <summary>
    /// Create Catalogue for store
    /// </summary>
    private void CreateCatalogue()
    {
        for( int i = 0; i < i_NumberOfProducts; ++i)
        {

            // TODO fill a screptable object catalogue
            int i_randomIndex = UnityEngine.Random.Range(0, a_pd_UIItem.Length - 1);
            GameObject go_ListElement = Instantiate(go_UIItem, t_parent);
            ProductSelected ps_element = go_ListElement.GetComponent<ProductSelected>();
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
