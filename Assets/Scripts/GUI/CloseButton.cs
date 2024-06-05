using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseButton : MonoBehaviour
{
    /// <summary>
    /// Hides the mouse
    /// </summary>
    public void HideMouse()
    {
        Cursor.visible = false;
    }

    /// <summary>
    /// Enable the players controller
    /// </summary>
    public void EnablePlayerMovement()
    {
        Player.Instance.EnablePlayerMovement();
        Player.Instance.EnablePlayerInteraction();
        Player.Instance.SetActiveFalse();
    }
}
