using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuyItem : MonoBehaviour
{
    public Wallet walletScript;
    public ItemDisplay displayedItem;

    public void Buy()
    {
        if(walletScript.gold >= displayedItem.itemCost)
        {
            walletScript.gold -= displayedItem.itemCost;

            Debug.Log("You just bought " + displayedItem.itemName + " for " + displayedItem.itemCost + " pieces of gold");

            //Anything you want to do after buying item put here

        }
    }
}
