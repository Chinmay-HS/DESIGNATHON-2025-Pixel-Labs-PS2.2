using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class HideUi : MonoBehaviour
{
    [SerializeField] private GameObject[] houses;
    [SerializeField] private GameObject viewCost, customise, scanningText;

    void Start()
    {
        viewCost.SetActive(false);
        customise.SetActive(false);
        scanningText.SetActive(true);
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
            viewCost.SetActive(true);
            customise.SetActive(true);
            scanningText.SetActive(false);
        }
        else
        {
            viewCost.SetActive(false);
            customise.SetActive(false);
            scanningText.SetActive(true);
        }
    }
}
