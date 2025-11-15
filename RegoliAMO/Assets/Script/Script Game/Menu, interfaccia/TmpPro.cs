using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class TmpProScript : MonoBehaviour
{
    // Variabile statica condivisa tra gli oggetti
    public static int tmpProValue = 0;

    // Riferimento al componente TextMeshPro
    public TextMeshProUGUI tmpProText;

    // Metodo per aggiornare il testo di TextMeshPro
    public void UpdateTmpProText()
    {
        // Assicurati che il riferimento a TextMeshPro sia stato assegnato
        if (tmpProText != null)
        {
            // Aggiorna il testo con il valore corrente di tmpProValue
            tmpProText.text = "TMP: " + tmpProValue;
        }
        else
        {
            // Stampa un avviso se il riferimento a TextMeshPro non è stato assegnato
            Debug.LogWarning("Il riferimento a TextMeshPro non è stato assegnato a TmpProScript.");
        }
    }

}