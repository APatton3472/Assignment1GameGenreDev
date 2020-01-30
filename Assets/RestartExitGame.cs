using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RestartExitGame : MonoBehaviour
{
    public void play()
    {
        Application.LoadLevel(1);
    }
    public void exit()
    {
        Application.Quit();
    }
}
