using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleForever : MonoBehaviour
{
    public Vector3 setScale = new Vector3(1.0f,1.0f,1.0f); //example of 'struct' type variable where you initialize
                                                           //a new varible of Vector3, or other type of struct
    /*public is an access modifier meaning it's available to other scripts and available in the inspector
    if you don't write public it's automatically private
     */
    // Start is called before the first frame update
    void Start()
    {
        // transform.localScale = setScale;   //transform.localScale = transform.localScale + setScale;
                                             // can also use transform.localScale as a value to add
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = ScaleVector(transform.localScale);

    }

    Vector3 ScaleVector(Vector3 inVector)
    {
        Vector3 outVector;
        outVector = inVector + setScale*Time.deltaTime;
        return outVector;
    }
}
