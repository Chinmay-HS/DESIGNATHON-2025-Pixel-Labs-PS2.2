using UnityEngine;

public class ModelCarryForward : MonoBehaviour
{
    public SelectedModelData modelData;

    public void SetSelectedModel(GameObject spawnedModel)
    {
        if (spawnedModel != null)
        {
            modelData.selectedModelTag = spawnedModel.tag; // Save the model's tag
            Debug.Log("Model saved to Scriptable Object: " + spawnedModel.tag);
        }
        else
        {
            Debug.LogError("Spawned model is null!");
        }
    }
}
