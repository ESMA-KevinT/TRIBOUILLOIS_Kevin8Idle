using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoutonByPrice : MonoBehaviour
{
    private MoneyManager _moneyManager;

    private ComicsReader _comicsReader;

    public int comicPrice;

    public Button buttonBuy;

    


    // Start is called before the first frame update
    void Start()
    {
        
        _moneyManager = FindObjectOfType<MoneyManager>();
        _comicsReader = FindObjectOfType<ComicsReader>();
    }

    // Update is called once per frame
    void Update()
    {
        if (comicPrice>_moneyManager.money || _comicsReader.available == false)
        {
            buttonBuy.interactable = false;
        }
        else 
        {
            buttonBuy.interactable = true;
            //_moneyManager.money-=comicPrice;
            

        }
    }
}
