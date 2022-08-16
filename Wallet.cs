using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Wallet : MonoBehaviour
{
    public int gold;
    public TextMeshProUGUI goldBalance;

    void Update()
    {
        goldBalance.SetText(gold.ToString());   //Keeps updating our wallet ballance onto the UI
    }
}
