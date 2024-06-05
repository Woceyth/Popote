using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EquippedGearInventory : MonoBehaviour
{
    private readonly int i_NumberOfSlots = 5;
    public int i_itemType;
    public int i_swapi_swapIndex;
    public ProductData[] a_pd_currenltyEquipped;
    public List<EquippedSlot> l_equippedSlot;
    public GameObject go_UIEquippedItem;
    public Transform t_parent;
    public SpriteRenderer s_playerHood;
    public SpriteRenderer s_playerVest;
    public SpriteRenderer s_playerBelt;
    public SpriteRenderer s_playerRightHand;
    public SpriteRenderer s_playerLeftHand;

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < i_NumberOfSlots; ++i)
        {
            // Make the list of the elements
            GameObject go_ListElement = Instantiate(go_UIEquippedItem, t_parent);
            EquippedSlot es_Element = go_ListElement.transform.GetComponentInChildren<EquippedSlot>();

            // Set the products details to equipment inventory
            es_Element.product = a_pd_currenltyEquipped[i];
            es_Element.i_icon.sprite = es_Element.product.icon;
            es_Element.i_type = es_Element.product.type;
            l_equippedSlot.Add(es_Element);
        }

        l_equippedSlot[0].gearText.text = "Head";
        l_equippedSlot[1].gearText.text = "Body";
        l_equippedSlot[2].gearText.text = "Waist";
        l_equippedSlot[3].gearText.text = "RightHand";
        l_equippedSlot[4].gearText.text = "LefHand";
    }

    public void ChangePlayersClothes()
    {
        s_playerHood.sprite = l_equippedSlot[0].i_icon.sprite;
        s_playerVest.sprite = l_equippedSlot[1].i_icon.sprite;
        s_playerBelt.sprite = l_equippedSlot[2].i_icon.sprite;
        s_playerRightHand.sprite = l_equippedSlot[4].i_icon.sprite;
        s_playerLeftHand.sprite = l_equippedSlot[3].i_icon.sprite;
}
}
