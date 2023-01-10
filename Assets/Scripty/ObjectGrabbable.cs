using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectGrabbable : MonoBehaviour
{
    private Rigidbody objectRigidbody;
    private Transform GameObject;
    
    
    
    private void Awake()
    {
        objectRigidbody = GetComponent<Rigidbody>(); 
    }

    public void Grab(Transform GameObject)
    {
        this.GameObject = GameObject;
    }
    private void FixedUpdate()
    {
        if (GameObject != null)
        {
            objectRigidbody.useGravity = false;
            objectRigidbody.MovePosition(GameObject.position);
        }
        else if(!objectRigidbody.useGravity)
        {
            //objectRigidbody.useGravity = true;
        }
    }
}
