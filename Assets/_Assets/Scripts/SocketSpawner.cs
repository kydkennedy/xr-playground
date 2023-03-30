using System.Collections;
using System.Collections.Generic;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine;

public class SocketSpawner : MonoBehaviour
{

    public Transform spawnPoint;
    public GameObject currentlyHeldPrefab;

    public void SpawnPrefab(GameObject prefabToSpawn)
    {
        if (currentlyHeldPrefab != null)
        {
            Destroy(currentlyHeldPrefab);
        }
        currentlyHeldPrefab = Instantiate(prefabToSpawn, spawnPoint.position, spawnPoint.rotation);

        Debug.Log("Spawning your doom");
    }

    public void ReleaseHeld()
    {
        currentlyHeldPrefab = null;
    }

    public void RegisterHeld(SelectEnterEventArgs args)
    {
        currentlyHeldPrefab = args.interactableObject.transform.gameObject;
    }
}
