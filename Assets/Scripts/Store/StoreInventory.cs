using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreInventory : MonoBehaviour
{
    public int i_NumberOfProducts;
    public GameObject go_UIItem;
    public GameObject[] a_go_UIItem;
    public List<GameObject> l_productList;
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
            GameObject go_ListElement = Instantiate(go_UIItem, t_parent);

            // TODO fill a screptable object catalogue
            //int i_randomIndex = UnityEngine.Random.Range(0, a_go_UIItem.Length-1);
            //GameObject go_ListElement = Instantiate(a_go_UIItem[i_randomIndex], t_parent);
        }
    }

    /// <summary>
    /// Deselect Every item
    /// </summary>
    public void DeselectEveryItem()
    {
        for (int i = 0; i < i_NumberOfProducts; ++i)
        {
            l_productList[i].GetComponent<ProductSelected>().DisableFrame();
        }
    }
}
