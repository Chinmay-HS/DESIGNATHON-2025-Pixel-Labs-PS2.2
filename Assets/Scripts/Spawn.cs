using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject spawn_point;
    public GameObject obj;


    public void Update()
    {
        //SpawnPosition();
    }

    public void SpawnPosition()
    {
        obj.transform.position = spawn_point.transform.position;
        obj.transform.rotation = spawn_point.transform.rotation;
    }
}
