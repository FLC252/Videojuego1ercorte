using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
    public void Playgame()
    {
        SceneManager.LoadScene("level1");
    }
    public void Quitgame()
    {
        Application.Quit();
    }
}
