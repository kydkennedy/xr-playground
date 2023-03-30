using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    int frameCount; //this is an instance variable and is accessible everywhere in our script as it's created outside of a method/function

    // Start is called before the first frame update
    void Start()
    {
        frameCount = 0;
        Debug.Log("Hello World");   
    }

    // Update is called once per frame
    void Update()
    {
        frameCount = ++frameCount; //also written as frameCount + 1
        string coolMessage = "Frame" + frameCount; //the string here is what is called a local variable --due to scope not available outside of Update()
        Debug.Log(coolMessage);
    }
}
