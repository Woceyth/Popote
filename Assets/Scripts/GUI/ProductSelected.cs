using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProductSelected : MonoBehaviour
{
    public int i_itemID;
    public GameObject go_iconFrame;

    /// <summary>
    /// When the player press the button it will communicate with the manager based on the selected product
    /// </summary>
    public void CommunicateWithManager()
    {
        Debug.Log("Pressed product button");
        go_iconFrame.SetActive(true);
    }

    public void DisableFrame()
    {
        go_iconFrame.SetActive(false);
    }
}
