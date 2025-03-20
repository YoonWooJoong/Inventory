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

    public void UpdateUI(Character player)
    {
        attack.text = $"{player.Attack}";
        defence.text = $"{player.Defence}";
        health.text = $"{player.Health}";
        critical.text = $"{player.Critical}";

    }
}
