using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayGame : MonoBehaviour
{
    private Sounds boolean;
    
    public void play()
    {
        SceneManager.LoadScene(1);
        Sounds.scene2 = true;
    }

    public void quit()
    {
        Application.Quit();
    }
}
