using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seller : MonoBehaviour
{
    public GameObject go_backgroundImage;
    public GameObject go_closeButton;
    public GameObject go_storeFrame;
    public GameObject go_inventoryFrame;
    public GameObject go_coinLabel;

    /// <summary>
    /// Action triggered a UnityEvent
    /// </summary>
    public void SellerAction()
    {
        //Debug.Log("Open the store");
        go_storeFrame.SetActive(true);
        go_backgroundImage.SetActive(true);
        go_closeButton.SetActive(true);
        go_coinLabel.SetActive(true);
        Cursor.visible = true;
    }
}
