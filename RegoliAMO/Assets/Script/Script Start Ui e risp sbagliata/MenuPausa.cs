using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    // Proprietà per il testo di debug
    public string debugText = "Debug";

    // Funzione per attivare il testo di debug
    public void ShowDebugText()
    {
        Debug.Log(debugText);
      
    }

    // Funzione per disattivare un TextMeshPro dopo un certo numero di secondi
 

    // Funzione per gestire il tocco del mouse e del touch
    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.touchCount > 0)
        {
            // Il mouse è stato cliccato o c'è un tocco sullo schermo

            // Mostra il testo di debug
            ShowDebugText();
        }
    }
}
