using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    [SerializeField] private GameObject mainButtons;
    public GameObject MainButtons { get { return mainButtons; }}

    [SerializeField] private GameObject statusUI;
    public GameObject StatusUI { get { return statusUI; }}

    [SerializeField] private GameObject inventoryUI;
    public GameObject InventoryUI { get { return inventoryUI; }}

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
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
