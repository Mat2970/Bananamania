using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ConteoPorSeg : MonoBehaviour
{
    public int moneyCounter;
    public int moneyPerSecond;
    public Text moneyPerSecondDisplay;
    private int lastMoneyCount;
    private float elapsedTime;

    private void Start()
    {
        lastMoneyCount = moneyCounter;
    }

    private void Update()
    {
        moneyCounter = Contador.bananaCount;
        elapsedTime += Time.deltaTime;
        if (elapsedTime >= 1f)
        {
            elapsedTime = 0f;
            moneyPerSecond = moneyCounter - lastMoneyCount;
            lastMoneyCount = moneyCounter;
        }

        moneyPerSecondDisplay.text = AbbreviateNumber(moneyPerSecond) + " bananas por segundo";
    }

    private string AbbreviateNumber(int number)
    {
         if (number >= 1000000000)
         {
             return (number / 1000000000f).ToString("0.##") + "C";
         }
         else if (number >= 1000000)
         {
             return (number / 1000000f).ToString("0.##") + "M";
         }
         else if (number >= 1000)
         {
             return (number / 1000f).ToString("0.##") + "K";
         }
         else
         {
        return number.ToString();
         }
    }
}

