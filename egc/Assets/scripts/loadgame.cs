using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadgame : MonoBehaviour
{
    // Start is called before the first frame update
   public void loadLEVEL()
    {
        SceneManager.LoadScene("main hub");
    }
    public void exitlevel()
    {
        Application.Quit();
    }
}
