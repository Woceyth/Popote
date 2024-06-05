using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinQuantityText : MonoBehaviour
{
    public TextMeshProUGUI tmp_conQuantityText;

    private void OnEnable()
    {
        tmp_conQuantityText.text = Player.Instance.GetMoneyQuantity().ToString();
    }
}
