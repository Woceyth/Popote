using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public static Player Instance;

    private int i_Money;
    public InputActionReference iar_Movement;
    public InputActionReference iar_Inventory;
    public GameObject go_backgroundImage;
    public GameObject go_closeButton;
    public GameObject go_inventoryFrame;
    public GameObject go_coinsLabel;

    private Vector2 v2_movementDirection;
    private float f_directionRecoded = 1f;
    private bool b_active = false;
    private readonly float f_speed = 13f;
    private new Rigidbody2D rigidbody2D;

    private void OnEnable()
    {
        Instance = this;
        iar_Inventory.action.started += Inventory;
    }

    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D = gameObject.GetComponent<Rigidbody2D>();
    }

    private void Inventory(InputAction.CallbackContext obj)
    {
        Debug.Log("Inventory");
        b_active = !b_active;
        go_inventoryFrame.SetActive(b_active);
        go_backgroundImage.SetActive(b_active);
        go_closeButton.SetActive(b_active);
    }

    // Update is called once per frame
    void Update()
    {
        v2_movementDirection = iar_Movement.action.ReadValue<Vector2>();
    }

    private void FixedUpdate()
    {
        rigidbody2D.velocity = new Vector2(v2_movementDirection.x * f_speed, v2_movementDirection.y * f_speed);
        if (v2_movementDirection.x != 0 )
        { 
            f_directionRecoded = Mathf.Round(v2_movementDirection.x);
        }
        transform.localScale = new Vector3( f_directionRecoded, 1f, 1f );
    }

    /// <summary>
    /// Get the current quantity you have at the moment
    /// </summary>
    /// <returns></returns>
    public int GetMoneyQuantity()
    {
        return i_Money;
    }

    /// <summary>
    /// Set the new quantity you have
    /// </summary>
    /// <param name="newQuantity"></param>
    public void SetMoneyQuantity( int newQuantity)
    {
        i_Money = newQuantity;
    }

    private void OnDestroy()
    {
        Instance = null;
        iar_Inventory.action.started -= Inventory;
    }
}
