using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Vuforia;

public class ModelSpawn : MonoBehaviour
{
    public GameObject M1;
    public GameObject M1_inCostEstimation;
    public GameObject M2;  
    public GameObject M2_inCostEstimation;
    public GameObject M3;
    public GameObject M3_inCostEstimation;
    public GameObject M4;
    public GameObject M4_inCostEstimation;
    public GameObject M5;
    public GameObject M5_inCostEstimation;

    void Start()
    {
        // Initialize your script
    }

    public void OnButtonClick()
    {
        // Perform actions specific to this model
        Debug.Log("Button clicked for model: " + gameObject.name);
    }

    public void ModelDetection()
    {
        if (M1.CompareTag("House 1") && M1.activeInHierarchy)
        {
            M1_inCostEstimation.SetActive(true);
        }

        if (M2.CompareTag("House 2") && M2.activeInHierarchy)
        {
            M2_inCostEstimation.SetActive(true);
        }

        if (M3.CompareTag("House 3") && M3.activeInHierarchy)
        {
            M3_inCostEstimation.SetActive(true);
        }

        if (M4.CompareTag("House 4") && M4.activeInHierarchy)
        {
            M4_inCostEstimation.SetActive(true);
        }

        if (M5.CompareTag("House 5") && M5.activeInHierarchy)
        {
            M5_inCostEstimation.SetActive(true);
        }
    }
}
