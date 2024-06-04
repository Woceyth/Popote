using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class Interactable : MonoBehaviour
{
    public bool b_isInRange;
    public InputActionReference iar_Interact;
    public UnityEvent interactEvent;

    private void OnEnable()
    {
        iar_Interact.action.started += Interact;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        b_isInRange = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        b_isInRange = false;
    }

    /// <summary>
    /// Interacts and triger the Unity event
    /// </summary>
    /// <param name="obj"></param>
    private void Interact(InputAction.CallbackContext obj)
    {
        if (b_isInRange)
        {
            //Debug.Log("Interacting");
            interactEvent.Invoke();
        }
    }

    private void OnDisable()
    {
        iar_Interact.action.started += Interact;
    }
}
