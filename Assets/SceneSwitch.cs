using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneSwitch : MonoBehaviour
{
    public GameObject house1;
    public Transform house1campos;
    public GameObject house2;
    public Transform house2campos;
    public GameObject house3;
    public Transform house3campos;
    public GameObject house4;
    public Transform house4campos;
    public GameObject house5;
    public Transform house5campos;

    public GameObject fpsplayer;
    public GameObject fpsplayerh5;

    public GameObject m1;
    public GameObject m2;
    public GameObject m3;
    public GameObject m4;
    public GameObject m5;


    public void sceneSwitch()
    {
        if (m1.CompareTag("House 1") && m1.activeInHierarchy)
        {
            house1.SetActive(true);
            fpsplayer.transform.position = house1campos.transform.position;
            fpsplayer.transform.rotation = house1campos.transform.rotation;
        }

        if (m2.CompareTag("House 2") && m2.activeInHierarchy) 
        {
            house2.SetActive(true);
            fpsplayer.transform.position = house2campos.transform.position;
            fpsplayer.transform.rotation = house2campos.transform.rotation;
        }

        if (m3.CompareTag("House 3") && m3.activeInHierarchy)
        {
            house3.SetActive(true);
            fpsplayer.transform.position = house3campos.transform.position;
            fpsplayer.transform.rotation = house3campos.transform.rotation;
        }

        if (m4.CompareTag("House 4") && m4.activeInHierarchy)
        {
            house4.SetActive(true);
            fpsplayer.transform.position = house4campos.transform.position;
            fpsplayer.transform.rotation = house4campos.transform.rotation;
        }

        if (m5.CompareTag("House 5") && m5.activeInHierarchy)
        { 
            house5.SetActive(true);
            fpsplayerh5.SetActive(true);    
        }
    }
}
