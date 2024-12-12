using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopController : MonoBehaviour
{

    public GameObject Shop;

    private bool shopOpened = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OpenShop()
    {
        shopOpened = !shopOpened;
        Shop.SetActive(true);
    }

    public void CloseShop()
    {
        shopOpened = false;
        Shop.SetActive(false);
    }
}
