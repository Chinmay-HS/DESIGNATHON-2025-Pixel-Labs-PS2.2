using Fusion;
using UnityEngine;

public class FurnitureNetworkSync : NetworkBehaviour
{
    [SerializeField] private GameObject furnitureModel;

    public void ToggleFurniture() // ✅ Must be public
    {
        if (Runner.IsServer)
        {
            bool newState = !furnitureModel.activeSelf;
            RPC_SetFurnitureActive(newState);
        }
    }

    [Rpc(RpcSources.All, RpcTargets.All)]
    private void RPC_SetFurnitureActive(bool isActive)
    {
        furnitureModel.SetActive(isActive);
    }
}