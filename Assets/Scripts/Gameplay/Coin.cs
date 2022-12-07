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
            PointsAdd.Undo();
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name == "Player")
        {
            PointsAdd.Execute();
        }
    }

}
