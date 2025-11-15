using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MenuRispostaSbagliata : MonoBehaviour
{
    
    public void OnRiprovaButton()
    {
    
        SceneManager.LoadScene(1);
        
    }
    public void OnRiprovaAiutoButton()
    {

        SceneManager.LoadScene(2);

    }
    public void OnQuitButton()
    {
        Application.Quit();
    }
}
