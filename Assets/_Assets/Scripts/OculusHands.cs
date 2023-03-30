using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class OculusHands : MonoBehaviour

    
{
    Animator anim;
    public InputActionReference gripReference, triggerReference;



    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

        gripReference.action.started += GripPressed;
        gripReference.action.canceled += GripCancelled;

        triggerReference.action.started += TriggerPressed;
        triggerReference.action.canceled += TriggerCancelled;

    }

    private void OnDestroy()
    {
        gripReference.action.started -= GripPressed;
        gripReference.action.canceled -= GripCancelled;

        triggerReference.action.started -= TriggerPressed;
        triggerReference.action.canceled -= TriggerCancelled;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GripPressed(InputAction.CallbackContext junk){
        Debug.Log("Grip Pressed");
        anim.SetBool("GripPressed", true);
    }

        void GripCancelled(InputAction.CallbackContext junk){
        Debug.Log("Grip Cancelled");
        anim.SetBool("GripPressed", false);
    }

        void TriggerPressed(InputAction.CallbackContext junk){
        Debug.Log("Trigger Pressed");
        anim.SetBool("TriggerPressed", true);
    }

        void TriggerCancelled(InputAction.CallbackContext junk){
        Debug.Log("Trigger Cancelled");
        anim.SetBool("TriggerPressed", false);
    }
}
