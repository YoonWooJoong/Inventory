using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    [SerializeField] Character playerPrefab;
    private Character player;

    public Character Player
    {
        get { return player; }
        set { player = value; }
    }
    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            if(Instance != this)
                Destroy(gameObject);
        }
        player = Instantiate(playerPrefab);
        SetData();
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void SetData()
    {
        Player.Init(Player);
    }
}
