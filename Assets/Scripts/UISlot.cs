using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UISlot : MonoBehaviour
{
    [SerializeField] private Image itemImage;
    [SerializeField] private int index;
    public GameObject EquipImage;
    public Button slotButton;
    public bool isEquip;
    public Item itemData;


    public void SetItem(int _index)
    {
        index = _index;
        EquipImage.SetActive(false);
        GameManager.Instance.Player.addItem += RefreshUI;
        slotButton.onClick.AddListener(OnSelectItem);
        
    }

    public void OnSelectItem()
    {
        UIManager.instance.InventoryUI.OnSelectItem(index);
    }

    private void RefreshUI()
    {
        if (itemData != null)
        {
            itemImage.sprite = itemData.itemImage;
        }
    }

}
