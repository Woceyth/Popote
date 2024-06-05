using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New StoreData", menuName ="GameStore/New Product")]
public class ProductData : ScriptableObject
{
    public new string name;
    public string description;
    public int cost;
    public int type;
    public Sprite icon;
}
