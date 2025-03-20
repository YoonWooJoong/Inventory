using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    public Button statusButton;
    public Button inventoryButton;

    public TextMeshProUGUI id;
    public TextMeshProUGUI lv;
    public TextMeshProUGUI lvBarText;

    void Start()
    {
        statusButton.onClick.AddListener(OpenStatus);
        inventoryButton.onClick.AddListener(OpenInventory);
    }

    public void OpenMainButton()
    {
        UIManager.instance.MainButtons.SetActive(true);
    }

    public void OpenStatus()
    {
        UIManager.instance.MainButtons.SetActive(false);
        UIManager.instance.StatusUI.SetActive(true);
    }

    public void OpenInventory()
    {
        UIManager.instance.MainButtons.SetActive(false);
        UIManager.instance.InventoryUI.SetActive(true);
    }

}
