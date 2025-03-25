using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIMainMenu : MonoBehaviour
{
    public Button statusButton;
    public Button inventoryButton;
    public Button additemButton;

    public TextMeshProUGUI id;
    public TextMeshProUGUI lv;
    public TextMeshProUGUI lvBarText;
    public TextMeshProUGUI money;

    void Start()
    {
        statusButton.onClick.AddListener(OpenStatus);
        inventoryButton.onClick.AddListener(OpenInventory);
        additemButton.onClick.AddListener(OnAddItem);
        UpdateUI(GameManager.Instance.Player);
    }

    public void OpenMainButton()
    {
        UIManager.instance.MainButtons.SetActive(true);
    }

    public void OpenStatus()
    {
        UIManager.instance.MainButtons.SetActive(false);
        UIManager.instance.StatusUI.gameObject.SetActive(true);
    }

    public void OpenInventory()
    {
        UIManager.instance.MainButtons.SetActive(false);
        UIManager.instance.InventoryUI.gameObject.SetActive(true);
    }

    private void UpdateUI(Character player)
    {
        id.text = player.name;
        lv.text = $"{player.level}";
        lvBarText.text = $"{player.exp}/{player.maxExp}";
        money.text = $"{player.money}";
    }

    public void OnAddItem()
    {
        GameManager.Instance.Player.Additem();
    }

}
