using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInfo : MonoBehaviour
{
    public void OnPlayButton()
    {
        SceneManager.LoadScene(1);
    }
    public void OnPlayWithHelpButton()
    {
        SceneManager.LoadScene(2);
    }
    public void OnClickQuitButton()
    {
        // Esce dall'applicazione
        Application.Quit();
    }
}
