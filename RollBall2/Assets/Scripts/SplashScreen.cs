using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour
{
    public static int ScreenNumber;
    // Start is called before the first frame update
    

    public void startGame()
    {
        if (ScreenNumber ==0)
        {
            ScreenNumber = 1;
            SceneManager.LoadScene(ScreenNumber);
        }
       
    }
}
