using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalObject : MonoBehaviour
{
    public GameObject[] PortalDoor;
    bool Switch = true;
    Vector3 BlueDoor;
    Vector3 OrangeDoor;

    private void Start()
    {
        BlueDoor = new Vector3(PortalDoor[0].transform.position.x, PortalDoor[0].transform.position.y, PortalDoor[0].transform.position.z-0.1f);
        OrangeDoor = new Vector3(PortalDoor[1].transform.position.x, PortalDoor[1].transform.position.y, PortalDoor[1].transform.position.z-0.1f);
    }

    private void Update()
    {
        if(Switch)
        {
            transform.LookAt(transform.position);
            transform.Translate(Vector3.forward * 0.01f * Time.deltaTime);
        }
        else
        {
            transform.LookAt(transform.position);
            transform.Translate(Vector3.forward * 0.01f * Time.deltaTime);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(Switch)
        {
            if (collision.gameObject.tag == "Blue")
            {
                transform.position = transform.position;
                Switch = !Switch;
                Debug.Log("Hello");
            }
        }
        else
        {
            if(collision.gameObject.tag == "Orange")
            {
                transform.position = transform.position;
                Switch = !Switch;
            }
        }
    }
}
