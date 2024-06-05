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
    public GameObject go_iconFrame;

    // Start is called before the first frame update
    public void MakeButtonInteractable()
    {
        bi_bagInventoryParent.i_swapIndex = is_inventorySlotScript.i_index;

        if (bi_bagInventoryParent.a_is_UIItem[bi_bagInventoryParent.i_swapIndex].product != null)
        {
            equipButton.interactable = true;
            bi_bagInventoryParent.DeselectEveryItem();
            go_iconFrame.SetActive(true);
        }
    }

    public void SetProductCost()
    {
        bi_bagInventoryParent.i_swapIndex = is_inventorySlotScript.i_index;

        if (bi_bagInventoryParent.a_is_UIItem[bi_bagInventoryParent.i_swapIndex].product != null)
        {
            sellButton.interactable = true;
            InventoryManager.Instance.SetProductCostToSell(bi_bagInventoryParent.a_is_UIItem[is_inventorySlotScript.i_index].product.cost);
        }
    }

    /// <summary>
    /// Disables the frame
    /// </summary>
    public void DisableFrame()
    {
        Debug.Log("DisableFrame");
        go_iconFrame.SetActive(false);
    }
}
