using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
  public void QuitGame () {
        Debug.log("Exit");
        Application.Quit();
    }    
}
