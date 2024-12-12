using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoutonByPrice : MonoBehaviour
{
    private MoneyManager _moneyManager;

    public int comicPrice;

    public Button buttonBuy;


    // Start is called before the first frame update
    void Start()
    {
        
        _moneyManager = FindObjectOfType<MoneyManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (comicPrice>_moneyManager.money)
        {
            buttonBuy.interactable = false;
        }
        if (comicPrice < _moneyManager.money)
        {
            buttonBuy.interactable = true;
            //_moneyManager.money-=comicPrice;
        }
    }
}
