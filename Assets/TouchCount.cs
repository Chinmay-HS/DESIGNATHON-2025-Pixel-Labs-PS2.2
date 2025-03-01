using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TouchCount : MonoBehaviour
{
[SerializeField] private GraphicRaycaster raycaster;

    void Start()
    {
        // Get the GraphicRaycaster component attached to this GameObject
        raycaster = GetComponent<GraphicRaycaster>();
    }

    void Update()
    {
        // Check for touch input
        if (Input.touchCount > 0)
        {
            // Enable the GraphicRaycaster when touch is detected
            raycaster.enabled = true;
        }
        else
        {
            // Disable the GraphicRaycaster when no touch is detected
            raycaster.enabled = false;
        }
    }
}
