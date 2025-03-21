using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIStatus : MonoBehaviour
{
    public TextMeshProUGUI attack;
    public TextMeshProUGUI defence;
    public TextMeshProUGUI health;
    public TextMeshProUGUI critical;
    public Button closeButton;

    private void Start()
    {
        closeButton.onClick.AddListener(OnCloseButton);
        UpdateUI(GameManager.Instance.Player);
    }
    public void UpdateUI(Character player)
    {
        attack.text = $"{player.attack}";
        defence.text = $"{player.defence}";
        health.text = $"{player.health}";
        critical.text = $"{player.critical}";

    }
    public void OnCloseButton()
    {
        UIManager.instance.MainButtons.SetActive(true);
        UIManager.instance.StatusUI.gameObject.SetActive(false);
    }
}
