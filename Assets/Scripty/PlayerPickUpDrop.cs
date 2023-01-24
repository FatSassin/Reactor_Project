using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickUpDrop : MonoBehaviour
{

    [SerializeField] private Transform CameraPos;
    [SerializeField] private Transform GameObject;
    [SerializeField] private LayerMask pickUpLayerMask;

    private ObjectGrabbable objectGrabbable;
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (objectGrabbable == null)
            {
                float pickUpDistance = 888f;
                if (Physics.Raycast(CameraPos.position, CameraPos.forward, out RaycastHit raycastHit, pickUpDistance))
                {
                    if (raycastHit.transform.TryGetComponent(out objectGrabbable))
                    {
                        objectGrabbable.Grab(GameObject);
                    }
                }

            }
            else
            {
                objectGrabbable.Drop();
                objectGrabbable = null;
            }
        
        
        
        }
            
        
    
    
    
    }





}
