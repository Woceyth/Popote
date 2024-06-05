using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySelected : MonoBehaviour
{
    public Button equipButton;
    public Button sellButton;
    public BagInventory bi_bagInventoryParent;
    public InventorySlot is_inventorySlotScript;

    // Start is called before the first frame update
    public void MakeButtonInteractable()
    {
        equipButton.interactable = true;
        bi_bagInventoryParent.i_swapIndex = is_inventorySlotScript.i_index;

        if(bi_bagInventoryParent.a_is_UIItem[bi_bagInventoryParent.i_swapIndex] != null )
        {
            Debug.Log("Product name: " + bi_bagInventoryParent.a_is_UIItem[bi_bagInventoryParent.i_swapIndex].product.name);
        }
        else
        {
            Debug.Log("It is empty");
        }
    }

    public void SetProductCost()
    {
        sellButton.interactable = true;
        bi_bagInventoryParent.i_swapIndex = is_inventorySlotScript.i_index;

        if (bi_bagInventoryParent.a_is_UIItem[bi_bagInventoryParent.i_swapIndex] != null)
        {
            InventoryManager.Instance.SetProductCostToSell(bi_bagInventoryParent.a_is_UIItem[is_inventorySlotScript.i_index].product.cost);
        }
        else
        {
            Debug.Log("It is empty");
        }
        
    }
}
