using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIInventory : MonoBehaviour
{
    public Button closeButton;
    public UISlot uiSlot;
    public List<UISlot> slotList;
    public Transform slots;
    private int slotsCount = 21;

    public void InitInventoryUI()
    {
        for (int i = 0; i < slotsCount; i++)
        {
            slotList.Add(Instantiate(uiSlot));
            slotList[i].transform.SetParent(slots,false);
            slotList[i].SetItem(i);
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
