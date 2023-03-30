using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventOnTrigger : MonoBehaviour
{
    public UnityEvent OnEnter; //title event variables (here reference variable) with Capital first

    public string tagToCheck;

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag(tagToCheck))
        {
            Debug.Log(other.name);
            OnEnter.Invoke();
        }
    }
}
