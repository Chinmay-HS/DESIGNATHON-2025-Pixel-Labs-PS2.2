using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RotateModel : MonoBehaviour
{
public float rotationSpeed = 10f;
public Vector3 vec;
    public void Update() 
    {
                transform.Rotate(vec * rotationSpeed * Time.deltaTime);

    }

}
