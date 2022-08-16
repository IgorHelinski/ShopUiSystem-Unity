using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ItemDisplay : MonoBehaviour
{
    public ItemObjcet displayedItem;

    //Logic (do not assign in inspector)
    public string itemName;
    public string itemDescription;
    public Sprite itemIcon;
    public int itemCost;
    public string itemType;

    //Graphics
    public TextMeshProUGUI itemNameUI;
    public TextMeshProUGUI itemDescriptionUI;
    public Image itemIconUI;
    public TextMeshProUGUI itemCostUI;
    public TextMeshProUGUI itemTypeUI;


    public void Start()         //Sets variables from itemObject to UI template
    {
        itemName = displayedItem.name;
        itemDescription = displayedItem.description;
        itemIcon = displayedItem.icon;
        itemCost = displayedItem.cost;
        itemType = displayedItem.selectItemType.ToString();

        itemNameUI.text = itemName;
        itemDescriptionUI.text = itemDescription;
        itemIconUI.sprite = itemIcon;
        itemCostUI.text = itemCost.ToString();
        itemTypeUI.text = itemType;
    }

    public void Display()   //Sets variables from itemObject to UI template
    {
        itemName = displayedItem.name;
        itemDescription = displayedItem.description;
        itemIcon = displayedItem.icon;
        itemCost = displayedItem.cost;
        itemType = displayedItem.selectItemType.ToString();

        itemNameUI.text = itemName;
        itemDescriptionUI.text = itemDescription;
        itemIconUI.sprite = itemIcon;
        itemCostUI.text = itemCost.ToString();
        itemTypeUI.text = itemType;
    }
}
