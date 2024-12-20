using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeButton : MonoBehaviour
{
    private MoneyManager _moneyManager;

    //private ComicsReader _comicsReader;

    //public int comicPrice;

    public Button buttonBuy;

    //public Comics comicToAdd;

    public bool available;

    [SerializeField]
    private int _upgradePrice;

    public void SetAvailabl(bool value)
    {
        available = value;
    }


    // Start is called before the first frame update
    void Start()
    {

        _moneyManager = FindObjectOfType<MoneyManager>();
        //_comicsReader = FindObjectOfType<ComicsReader>();
    }

    // Update is called once per frame
    void Update()
    {
        if (_upgradePrice > _moneyManager.money || available == false)
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
