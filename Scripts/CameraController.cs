using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private float speed;
    private float currentPosX;
    private float currentPosY;
    private Vector3 velocity = Vector3.zero;
    [SerializeField] private Transform player;

    private void Update()
    {

        //transform.position = Vector3.SmoothDamp(transform.position, new Vector3(currentPosX.position.x,transform.position.y,transform.position.z), ref velocity, speed);
        //transform.position = new Vector3(currentPosX.position.x, currentPosY.position.y, transform.position.z);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            GetComponent<Camera>().depth = 10;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            GetComponent<Camera>().depth = -10;
        }
    }
    

    public void MoveToNewRoom(Transform _newRoom)
    {
        //currentPosX = _newRoom.position.x;
        //currentPosY = _newRoom.position.y;
    }

}
