using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    [SerializeField]
    public int money;
    [SerializeField]
    private TextMeshProUGUI moneyText;

    private ComicsReader cr;


    public int multiplier = 0; 

    private void Start()
    {
        cr = FindFirstObjectByType<ComicsReader>();
        
    }
    public void ChangeMoney(int newMoney)
    {
        money = newMoney;
        moneyText.text = money.ToString();
    }

    public void RiseMoney()
    {
        
        ChangeMoney(money + cr._currentComics.comicsPrice * Mathf.Max(1,multiplier));
    }

    public void multiplyScore(int newMultiply)
    {
        multiplier += newMultiply;
        //UpgradeButton.available = false;
    }
}
