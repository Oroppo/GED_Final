using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    List<Transform> Objects= new List<Transform>();

    [SerializeField]
    public GameObject PooledObject;
    public GameObject Player;

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.X))
        {
            Objects.Add(Instantiate(Player.transform));
        }
    }
}
