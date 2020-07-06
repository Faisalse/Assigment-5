using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour
{
    public  int ScreenNumber = 0;
    public AudioSource abbb;
    // Start is called before the first frame update

    private void Start()
    {
        abbb.Play();
    }
    public void startGame()
    {
       
        if (ScreenNumber ==0)
        {
            ScreenNumber = 1;
            SceneManager.LoadScene(ScreenNumber);

        }
       
    }
}
