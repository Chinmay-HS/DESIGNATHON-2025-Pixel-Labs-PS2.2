using UnityEngine;

[CreateAssetMenu(fileName = "SelectedModelData", menuName = "ScriptableObjects/SelectedModelData", order = 1)]
public class SelectedModelData : ScriptableObject
{
    public string selectedModelTag; // Store the model tag
}