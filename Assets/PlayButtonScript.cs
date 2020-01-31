using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayButtonScript : MonoBehaviour
{
    public void play()
    {
        Application.LoadLevel(1);
    }
    public void credits()
    {
        Application.LoadLevel(4);
    }
}
