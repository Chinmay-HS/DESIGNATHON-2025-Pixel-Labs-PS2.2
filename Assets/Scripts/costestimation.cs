using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Globalization;
using Unity.VisualScripting;
using UnityEngine.UI;

public class costestimation : MonoBehaviour
{
    //private float final_cost_f;    
    public TMP_InputField noOfSlabs;
    public TMP_InputField carpetArea;
    public TMP_InputField constructionCost;
    private int totalCarpetArea;
    //public float constructionCost;
    private double totalCost;
    public TextMeshProUGUI totalCostUI;


    private void Update()
    {
        if(noOfSlabs.text == string.Empty) 
        {
            totalCostUI.text = " ";
            
        }
        if (carpetArea.text == string.Empty)
        {
            totalCostUI.text = " ";

        }
        if (constructionCost.text == string.Empty)
        {
            totalCostUI.text = " ";
        }
        else
        {
            TotalCarpetArea();
        }





    }


    public void TotalCarpetArea()
    {
        int slabFloat = int.Parse(noOfSlabs.text, CultureInfo.InvariantCulture.NumberFormat);
        int carpetFloat = int.Parse(carpetArea.text, CultureInfo.InvariantCulture.NumberFormat);
        double constructionCostFloat = double.Parse(constructionCost.text, CultureInfo.InvariantCulture.NumberFormat);
        totalCarpetArea = slabFloat * carpetFloat;
        totalCost = totalCarpetArea * constructionCostFloat;
        totalCostUI.text = "The total cost of your dream home is INR " + totalCost.ToString() + "!";
        //ResetVal();
    }

    /*public void ResetVal()
    {
        if (noOfSlabs = null)
        {
            if (carpetArea = null)
            {
                if (constructionCost = null)
                {
                    totalCostUI.text = "0";

                }
            }
        }
    }*/


    /*public void Input_test()
    {
        float inputInFloatFormat = float.Parse(cost.text, CultureInfo.InvariantCulture.NumberFormat);
        final_cost_f = inputInFloatFormat * slapCost;
        totalCost.text = final_cost_f.ToString();
    }*/
}
