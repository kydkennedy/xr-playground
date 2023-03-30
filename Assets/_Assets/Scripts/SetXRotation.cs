using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetXRotation : MonoBehaviour
{
    public FollowOnRail rail;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*Quaternion newRotation = Quaternion.Euler(rail.valueOut,0,0);
        transform.rotation = newRotation; */
        // here we set the rotation of x for the skybox/6 sided skybox material
        // to the value of the rail.valueOut
        // this is a float between 0 and 360
        // we can use this to rotate the skybox starting on the next line
        RenderSettings.skybox.SetFloat("_Rotation", rail.valueOut);


    }
}
