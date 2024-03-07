using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    public static MenuController instance;

    public void PlayGame () {

        SCManager.instance.LoadScene("Level1");
    
    }

    public void Restart() 
    {
        SCManager.instance.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void Exit() 
    {
        Application.Quit();
    }
    

}
