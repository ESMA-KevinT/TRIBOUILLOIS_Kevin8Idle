using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ComicsReader : MonoBehaviour
{

    private int _currentPage;
    [SerializeField]
    private TextMeshProUGUI _pageText, _nameText, _priceText;
    [SerializeField]
    private Image _comicsImage;

    [SerializeField]
    public Comics _currentComics;

    [SerializeField]
    private List<Comics>_deck;

    private MoneyManager _moneyManager;

    private int _newPrice;

    void Start()
    {
        _moneyManager = FindObjectOfType<MoneyManager>();

        ReadComics(_deck[Random.Range(0, _deck.Count)]);
    }

    public void ReducePage()
    {
        _currentPage -= 10;
        _pageText.text = _currentPage.ToString("000");
        if (_currentPage <= 0)
        {
            _moneyManager.RiseMoney();
            ReadComics(_deck[Random.Range(0, _deck.Count)]);
        }
    }

    private void ReadComics(Comics newComics)
    {
        _currentComics = newComics;

        _currentPage = _currentComics.pageBase;

        _pageText.text = _currentComics.pageBase.ToString("00");
        _nameText.text = _currentComics.comicsName.ToString();
        _priceText.text = _currentComics.comicsPrice.ToString();


        _comicsImage.sprite = _currentComics.comicsImage;

        
    }


    public void AddComics(ComicsButton comicButton)
    {
        _deck.Add(comicButton.comicToAdd);
        
        comicButton.available = false;

    }

    public void SubstractMoney(int price)
    {
        _newPrice = _moneyManager.money -= price;

        _moneyManager.ChangeMoney(_newPrice);
    }


    //public void DeleteButton(Image comicButton)
    //{
      //  comicButton.enabled =true;
    //}

}

