using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour
{
    List<GameObject> Objects= new List<GameObject>();

    [SerializeField]
    public GameObject PooledObject;
    public GameObject Player;
    

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            Vector3 Diff = new Vector3(1, 0f, 0f);
            Quaternion Rot = new Quaternion();
            if (Objects.Count < 10)
            {
                Objects.Add(Instantiate(PooledObject, Diff + Player.transform.position, Rot));
            }
            else
            {
                foreach (GameObject Object in Objects)
                {
                    if (Object.activeSelf == false)
                    {
                        Object.transform.position = Diff + Player.transform.position;
                        Object.SetActive(true);
                        break;
                    }
                }
            }
        }

    }
}
