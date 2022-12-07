using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCount : MonoBehaviour
{
    TextMeshProUGUI TextComponent;
    CoinCounter coins;

    private void Start()
    {
        TextComponent = GetComponent<TextMeshProUGUI>();
        
    }
    private void Update()
    {
        TextComponent.text = "Score: " + CoinCounter._instance.Coins;
    }
}
