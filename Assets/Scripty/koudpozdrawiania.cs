using Unity.VisualScripting;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Runtime.CompilerServices;

public class koudpozdrawiania : MonoBehaviour
{
    private Camera characterCamera;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            var ray = characterCamera.ViewportPointToRay(Vector3.one * 0.5f);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 2f))
            {
                if (hit.collider.gameObject.GetComponent<interact>() != null)
                {
                    hit.collider.gameObject.GetComponent<interact>().pozdrawiam = true;
                }
            }
        }

    }

}            