using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIStatus : MonoBehaviour
{
    public TextMeshProUGUI attack;
    public TextMeshProUGUI defence;
    public TextMeshProUGUI health;
    public TextMeshProUGUI critical;

    private void Start()
    {
        UpdateUI(GameManager.Instance.Player);
    }
    private void UpdateUI(Character player)
    {
        Debug.Log($"{player.attack}");
        attack.text = $"{player.attack}";
        defence.text = $"{player.defence}";
        health.text = $"{player.health}";
        critical.text = $"{player.critical}";

    }
}
