using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    [SerializeField] private GameObject mainButtons;
    public GameObject MainButtons { get { return mainButtons; }}

    [SerializeField] private UIStatus statusUI;
    public UIStatus StatusUI { get { return statusUI; }}

    [SerializeField] private UIInventory inventoryUI;
    public UIInventory InventoryUI { get { return inventoryUI; }}

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else 
        {
            if (instance != this)
            {
                Destroy(gameObject);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        InventoryUI.InitInventoryUI();
    }

}
