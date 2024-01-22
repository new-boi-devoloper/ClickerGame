using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Game : MonoBehaviour
{
    //CLICKER
    public TMP_Text scoreText;
    public float currentScore;
    public float hitPower;
    public float scoreIncreasedPerSecond;
    public float x;

    //SHOP
    public int shop1prize;
    public TMP_Text shop1text;

    public int shop2prize;
    public TMP_Text shop2text;

    //AMOUNT
    public TMP_Text amount1Text;
    public int amount1;
    public float amount1Profit;

    public TMP_Text amount2Text;
    public int amount2;
    public float amount2Profit;

    //UPGRADE
    public int upgradePrize;
    public TMP_Text upgradeText;

    // Start is called before the first frame update
    public void Start()
    {
        //CLICKER
        currentScore = 0;
        hitPower = 1;
        scoreIncreasedPerSecond = 1;
        x = 0f;
    }

    // Update is called once per frame
    public void Update()
    {
        //CLICKER
        scoreText.text = (int)currentScore + " $";
        scoreIncreasedPerSecond = x * Time.deltaTime;
        currentScore += scoreIncreasedPerSecond;

        //SHOP
        shop1text.text = "Мелкий клик 1: " + shop1prize + " $";
        shop2text.text = "Среднестат клик 2: " + shop2prize + " $";

        //AMOUNT
        amount1Text.text = "Мелкий клик 1: " + amount1 + " Мелкий бонус$: " + amount1Profit + "/s";
        amount2Text.text = "Среднестат клик 2: " + amount2 + " Среднестат бонус $: " + amount2Profit + "/s";

        //UPGRADE
        upgradeText.text = "Cost: " + upgradePrize + " $";
    }

    public void Hit() => currentScore += hitPower;

    //SHOP
    public void Shop1()
    {
        if (currentScore >= shop1prize)
        {
            currentScore -= shop1prize;
            amount1 ++;
            amount1Profit++;
            x ++;
            shop1prize += 25;
        }
    }

    public void Shop2()
    {
        if (currentScore >= shop2prize)
        {
            currentScore -= shop2prize;
            amount2 ++;
            amount2Profit += 5;
            x += 5;
            shop2prize += 25;
        }
    }

    //UPGRADE
    public void Upgrade()
    {
        if (currentScore>=upgradePrize)
        {
            currentScore -= upgradePrize;
            hitPower *= 2;
            upgradePrize *= 2;
        }
    }
}