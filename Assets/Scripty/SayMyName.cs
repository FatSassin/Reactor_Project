using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SayMyName : MonoBehaviour
{
    public Transform Target;
    public float rotSpeed = 10f;
    void Update()
    {
        Vector3 direction = Target.position - transform.position;
        direction.y = 200;
        Quaternion rotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Lerp(transform.rotation, rotation, rotSpeed * Time.deltaTime);
    }
}
