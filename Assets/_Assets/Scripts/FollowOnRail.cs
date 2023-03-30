using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowOnRail : MonoBehaviour
{
    public float maxSliderSize = 0.5f;
    public Transform followTransform;
    public Transform targetTransform;
    public float valueOutMin, valueOutMax, valueOut;
    // Start is called before the first frame update
    void Start()
    {
        followTransform.parent = transform;    
    }

 // Update is called once per frame
    void Update()
    {
        DoFollow();
        CalcValue();
    }
    void DoFollow()
    {
        followTransform.position = targetTransform.position;
        float xPosition = Mathf.Clamp(followTransform.localPosition.x, 0, maxSliderSize);
        followTransform.localPosition = new Vector3(xPosition, 0 ,0);
    }

    public void SnapTargetToFollow(){
       targetTransform.position = followTransform.position; 
       targetTransform.rotation = followTransform.rotation;
    }

    void CalcValue(){
        float betweenZeroAndOne = Mathf.InverseLerp(0, maxSliderSize, followTransform.localPosition.x);
        valueOut = Mathf.Lerp(valueOutMin, valueOutMax, betweenZeroAndOne) ;
    }

    private void OnDrawGizmos() {
        
        Gizmos.DrawLine(transform.position, transform.TransformPoint(new Vector3(maxSliderSize, 0, 0)));

    }
   
}
