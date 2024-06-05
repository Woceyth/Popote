using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySelected : MonoBehaviour
{
    public Button buyButton;

    // Start is called before the first frame update
    public void MakeButtonInteractable()
    {
        buyButton.interactable = true;
    }
}
