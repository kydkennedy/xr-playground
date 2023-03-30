using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollision : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision collision)
    {
        //Debug.Log(collision.collider.name);
        Destroy(gameObject);
    }

  

}
