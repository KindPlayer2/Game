using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class keys : MonoBehaviour
{
    private int speed = 100;
    private Vector3 velocity = Vector3.zero;
    public bool gotten = false;
    [SerializeField] private Transform player;
    [SerializeField] private Transform door;
    private health Thing;
    //Vector3 orig = transform.position;
    
    // Start is called before the first frame update
    void Start()
    {
    }

    private void Awake()
    {
        Thing = GetComponent<health>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(gotten == true)
        {
            transform.position = Vector3.SmoothDamp(transform.position, new Vector3(player.position.x,player.position.y,transform.position.z), ref velocity, speed * Time.deltaTime);
            gameObject.tag = "Untagged";
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            gotten = true;
        }
    }


}
