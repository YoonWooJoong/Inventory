using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Character player;

    public Character Player
    {
        get { return player; }
        set { player = value; }
    }
    void Start()
    {
        SetData();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void SetData()
    {
        Player = new Character();
    }
}
