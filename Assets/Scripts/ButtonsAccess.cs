using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsAccess : MonoBehaviour
{

    public GameObject[] houses;
    public GameObject viewCostEstimationButton;
    public GameObject customizeButton;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool anyActive = false;

        // Check if any GameObject in the array is active
        foreach (GameObject obj in houses)
        {
            if (obj.activeInHierarchy)
            {
                anyActive = true;
                break;
            }
        }

        // Enable the specified GameObject if any GameObject in the array is active
        if (anyActive)
        {
            viewCostEstimationButton.SetActive(true);
            customizeButton.SetActive(true);
            
        }
        else
        {
            viewCostEstimationButton.SetActive(false);
            customizeButton.SetActive(false);
        }
    }
}