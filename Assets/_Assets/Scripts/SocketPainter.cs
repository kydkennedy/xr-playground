using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class SocketPainter : MonoBehaviour
{
    public GameObject sockettedObject;

    public void RegisterObject(SelectEnterEventArgs args)
    {
        sockettedObject = args.interactableObject.transform.gameObject;
    }

    public void ReleaseObject()
    {
        sockettedObject = null;
    }

    public void ChangeMaterial(Material newMaterial)
    {
        if (sockettedObject != null)
        {
           Renderer[] renderers = sockettedObject.GetComponentsInChildren<Renderer>();
            foreach(Renderer rend in renderers){
                rend.material = newMaterial;
            }
        }
    }

}
