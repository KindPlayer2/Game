using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class finired : MonoBehaviour
{

    private creditSong boolean;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            SceneManager.LoadScene(2);
            creditSong.scene3 = true;
        }
    }
}
