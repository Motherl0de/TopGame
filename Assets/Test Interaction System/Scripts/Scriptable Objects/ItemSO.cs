using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ItemType
{
    None=0,
    OpenClose,
    Picked
}

[CreateAssetMenu(fileName = "Item", menuName = "Item")]
public class ItemSO : ScriptableObject
{
    [SerializeField]
    public string _name;
    [SerializeField]
    private string _description;
    [SerializeField]
    private GameObject _prefab;


}
