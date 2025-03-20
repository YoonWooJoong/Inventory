using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private float _health;
    public float Health { get; private set; }
    private float _defence;
    public float Defence { get; private set; }
    private float _attack;
    public float Attack { get; private set; }
    private float _critical;
    public float Critical { get; private set; }
    private int _level;
    public int Level { get; private set; }
    private int _maxExp;
    public int MaxExp { get; private set; }
    private int _exp;
    public int Exp { get; private set; }
    private int _money;
    public int Money { get; private set; }

    public Character()
    {
        _health = 100;
        _defence = 10;
        _attack = 15;
        _critical = 25;
        _level = 1;
        _maxExp = 10;
        _exp = 0;
        _money = 1000;
    }

}
