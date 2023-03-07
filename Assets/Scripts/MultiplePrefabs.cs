using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit.AR;

public class MultiplePrfebs : MonoBehaviour
{
    public List<GameObject> Prefabs;
    private ARPlacementInteractable interactable;
    private int prefabIndex;

    private void Awake()
    {
        SetPrefabIndex();
        interactable = GetComponent<ARPlacementInteractable>();
        interactable.placementPrefab = Prefabs[prefabIndex];
    }

    private void SetPrefabIndex()
    {
        prefabIndex = Random.Range(0, Prefabs.Count);
    }

    public void ResetPrefab()
    {
        SetPrefabIndex();
        interactable.placementPrefab = Prefabs[prefabIndex];
    }

}
