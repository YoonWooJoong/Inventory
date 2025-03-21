using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public float health { get; private set; }
    public float defence { get; private set; }
    public float attack { get; private set; }
    public float critical { get; private set; }
    public int level { get; private set; }
    public int maxExp { get; private set; }
    public int exp { get; private set; }
    public int money { get; private set; }
    public string name { get; private set; }
    public List<Item> inventory;

    public Action addItem;

    public void Init(Character player)
    {
        player.name = "GiGa";
        player.health = 100;
        player.defence = 10;
        player.attack = 15;
        player.critical = 25;
        player.level = 1;
        player.maxExp = 10;
        player.exp = 0;
        player.money = 1000;

    }



    public void Additem()
    {
        for (int i = 0; i < inventory.Count; i++)
        {
           UIManager.instance.InventoryUI.slotList[i].itemData = inventory[i];
        }
        addItem?.Invoke();
    }
    

    


}
