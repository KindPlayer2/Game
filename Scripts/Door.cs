using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private Transform previousRoom;
    [SerializeField] private Transform nextRoom;
    [SerializeField] private Camera Cam;
/*
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            if(collision.transform.position.x < transform.position.x)
            {
                Cam.MoveToNewRoom(nextRoom);
                //Cam.transform.position = new Vector3(nextRoom.position.x, transform.position.y, transform.position.z - 10);
            }
            else
            {
                Cam.MoveToNewRoom(previousRoom);
                //Cam.transform.position = new Vector3(previousRoom.position.x, transform.position.y, transform.position.z - 10);
            }
            
            if(collision.transform.position.y < transform.position.y)
            {
                Cam.MoveToNewRoom(nextRoom);
                //Cam.transform.position = new Vector3(transform.position.x, nextRoom.position.y, transform.position.z - 10);
            }
            else
            {
                Cam.MoveToNewRoom(previousRoom);
                //Cam.transform.position = new Vector3(transform.position.x, previousRoom.position.y, transform.position.z - 10);
            }
        }
    }

*/}
