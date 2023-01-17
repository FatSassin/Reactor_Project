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
        objectRigidbody.useGravity = false;
    }
    public void Drop()
    {
        this.GameObject = null;
        objectRigidbody.useGravity = true;


    }
    private void FixedUpdate()
    {
        if (GameObject != null)
        {
            float lerpSpeed = 10f;
            Vector3 newPosition = Vector3.Lerp(transform.position, GameObject.position, Time.deltaTime * lerpSpeed);
            objectRigidbody.MovePosition(newPosition);
        }
        
    }
}
