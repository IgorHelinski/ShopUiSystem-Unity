using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemToChange : MonoBehaviour
{
    public ItemDisplay itemDisplayScript;
    public ItemObjcet itemToChange;

    public void ChangeItem()        //Changes actually displayed item for other item that you assign in inspector
    {
        itemDisplayScript.displayedItem = itemToChange;
        itemDisplayScript.Display();
    }
}
