using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackedObject : MonoBehaviour
{
    public GameObject destroyEffect;
   // public ObjectTracker tracker;
    // Start is called before the first frame update
    void Start()
    {
        //gameobject and transform are available from any script
        //tracker.AddToTrackedObjects(gameObject);
        ObjectTracker.Instance.AddToTrackedObjects(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnDestroy()
    {
        if(gameObject.scene.isLoaded){
            Instantiate(destroyEffect, transform.position, transform.rotation);
        }
        
    }

}

