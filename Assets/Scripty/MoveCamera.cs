using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Transform caneraPosition;
    // Update is called once per frame
    void Update()
    {
        transform.position = caneraPosition.position;
    }
}
