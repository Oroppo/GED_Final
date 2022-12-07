using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCounter : MonoBehaviour
{
    static public CoinCounter _instance;
    public int Coins =0;

    public void Start()
    {
        if (_instance == null)
        _instance = new CoinCounter();
    }

    public void IncreaseCount()
    {
        Coins++;
    }
    public void DecreaseCount()
    {
        Coins--;
    }
}
