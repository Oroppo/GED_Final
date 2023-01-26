using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupScript : MonoBehaviour
{
    PlayerController player;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.body.name == "Player")
        {
            player = collision.body.GetComponent<PlayerController>();
            DoAThing();
            //Destroy the object
            Destroy(transform);
        }
    }

    private void OnDestroy()
    {
        //called when the object dies
        DoAThing();
    }

    void DoAThing()
    {
        player.walkSpeed = 30;
    }
}
