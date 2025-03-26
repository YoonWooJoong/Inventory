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

    /// <summary>
    /// 플레이어 초기 세팅
    /// </summary>
    /// <param name="player"></param>
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


    /// <summary>
    /// 아이템 추가
    /// </summary>
    public void Additem()
    {
        for (int i = 0; i < inventory.Count; i++)
        {
           UIManager.instance.InventoryUI.slotList[i].itemData = inventory[i];
        }
        addItem?.Invoke();
    }

    /// <summary>
    /// 아이템 장착시 스텟 증가
    /// </summary>
    /// <param name="player"></param>
    /// <param name="item"></param>
    public void Equip(Character player, Item item)
    {
        player.attack += item.attack;
        player.defence += item.defence;
        player.health += item.health;
        player.critical += item.critical;
    }

    /// <summary>
    /// 아이템 장착해제시 스텟 하락
    /// </summary>
    /// <param name="player"></param>
    /// <param name="item"></param>
    public void UnEquip(Character player, Item item)
    {
        player.attack -= item.attack;
        player.defence -= item.defence;
        player.health -= item.health;
        player.critical -= item.critical;
    }
    


}
