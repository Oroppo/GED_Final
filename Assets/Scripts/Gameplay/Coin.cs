using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    CollectCommand PointsAdd;

    private void Start()
    {
        PointsAdd = new CollectCommand(transform);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            if(CoinCounter._instance.Coins>0)
            PointsAdd.Undo();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name == "Player")
        {
            PointsAdd.Execute();
            gameObject.SetActive(false);
            
        }
    }

}
