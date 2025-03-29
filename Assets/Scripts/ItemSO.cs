using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item" , menuName = "Inventory/item")]

public class ItemSO : ScriptableObject
{
    //기존 GameDB Excel 에서 선언한 변수를 나열 한다.
    public int id;
    public string itemName;
    public string nameEng;
    public string description;
    public ItemType itemType;
    public int price;
    public int power;
    public int level;
    public bool isStackable;
    public Sprite icon;                 //실제 사용할 스프라이트 선언
    public override string ToString()
    {
        return $"[{id}] {itemName} ({itemType}) - ���� : {price}���, �Ӽ� : {power}";
    }
    public string DisplayName
    {
        get { return string.IsNullOrEmpty(nameEng) ? itemName : nameEng; }
    }
}
