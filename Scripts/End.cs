using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class End : MonoBehaviour
{
    //private int counter;
    private keys KEY;
    private int speed = 100;
    private Vector3 velocity = Vector3.zero;
    [SerializeField] Transform OpenDoor;
    [SerializeField] playerMovement num;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(num.counter == 44)
        {
            transform.position = Vector3.SmoothDamp(transform.position, new Vector3(OpenDoor.position.x,OpenDoor.position.y,transform.position.z), ref velocity, speed * Time.deltaTime);
        }
    }

}
