using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteractScript : MonoBehaviour
{

    public float interactDiastance = 5f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, interactDiastance))
            {
                if (hit.collider != null && hit.collider.CompareTag("Door"))
                {
                    var doorScript = hit.collider.transform.parent.GetComponent<DoorScript>();
                    if (doorScript != null)
                    {
                        doorScript.ChangeDoorState();
                    }
                }
            }
        }

    }
}