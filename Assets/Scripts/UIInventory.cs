using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    public Button closeButton;
    public UISlot uiSlot;
    public List<UISlot> slotList;
    public RectTransform slots;
    private int slotsCount = 21;

    private void Start()
    {
        closeButton.onClick.AddListener(OnCloseButton);
    }

    /// <summary>
    /// 인벤토리 초기설정
    /// </summary>
    public void InitInventoryUI()
    {
        slotsCount = Mathf.CeilToInt(slots.rect.height / 70);
        for (int i = 0; i < slotsCount; i++)
        {
            slotList.Add(Instantiate(uiSlot));
            slotList[i].transform.SetParent(slots,false);
            slotList[i].SetItem(i);
        }
    }


    /// <summary>
    /// 슬롯을 눌렀다면
    /// </summary>
    /// <param name="index"></param>
    public void OnSelectItem(int index)
    {
        if (slotList[index].itemData == null)
            return;
        for (int i = 0; i < slotsCount; i++)
        {
            if (slotList[i] != slotList[index] && slotList[i].isEquip == true)
            {
                slotList[i].isEquip = false;
                slotList[i].EquipImage.SetActive(slotList[i].isEquip);
                GameManager.Instance.Player.UnEquip(GameManager.Instance.Player, slotList[i].itemData);
            }
        }
        slotList[index].isEquip = !slotList[index].isEquip;
        slotList[index].EquipImage.SetActive(slotList[index].isEquip);
        if(slotList[index].isEquip)
            GameManager.Instance.Player.Equip(GameManager.Instance.Player, slotList[index].itemData);
        else
            GameManager.Instance.Player.UnEquip(GameManager.Instance.Player, slotList[index].itemData);

        UIManager.instance.StatusUI.UpdateUI(GameManager.Instance.Player);
    }

    /// <summary>
    /// 닫기 버튼
    /// </summary>
    public void OnCloseButton()
    {
        UIManager.instance.MainButtons.SetActive(true);
        UIManager.instance.InventoryUI.gameObject.SetActive(false);
    }
}
