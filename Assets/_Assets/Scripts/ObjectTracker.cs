using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectTracker : MonoBehaviour
{
    public float totalDestructionTime = 2f;
      public List<GameObject> trackedObjects = new List<GameObject>(); //how to instantiate a list this is a public list 
                                                                      //available from the inspector
        public static ObjectTracker Instance; //this is a static variable that can be accessed from any script                        
    public void DestoryNow()
    {
        StartCoroutine(DestroyOverTime());
    }

    public void AddToTrackedObjects(GameObject obj){
        trackedObjects.Add(obj);
     
    }
        //awake happens when the game is loaded 
    void Awake(){
        if(Instance == null)
        {

            Instance = this;

        }
        else{
            Destroy(this);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator DestroyOverTime()
    {
        //Debug.Log("Boom");//this is a debug log to check if the function is working
        float timeBetween = totalDestructionTime / trackedObjects.Count;
        foreach (GameObject obj in trackedObjects)
        {
            Destroy(obj);
            yield return new WaitForSeconds(timeBetween);
        }

        trackedObjects.Clear();
    }
    
}
