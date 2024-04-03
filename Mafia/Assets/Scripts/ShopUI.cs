using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopUI : MonoBehaviour
{
    public GameObject ShopPanel;
    //public GameObject InventoryPanel;
    //public GameObject InventoryCanvas;

    public GameObject Player;
    public GameObject Shop;

    //bool activeShop = false;
    private float dist;

    private void Start()
    {
        ShopPanel.SetActive(false);
    }

    private void Update()
    {
        dist = Vector3.Distance(Player.transform.position, Shop.transform.position);
        if (dist < 3) //추가조건
        {

            //activeShop = true;
            //InventoryCanvas.SetActive(!activeShop);
            //InventoryPanel.SetActive(activeShop);
            ShopPanel.SetActive(true);
        }
        else
        {
            ShopPanel.SetActive(false);
        }
    }

}