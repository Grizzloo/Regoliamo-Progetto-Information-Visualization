using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Warning : MonoBehaviour
{
    public TextMeshProUGUI testoTMP;
    public GameObject OBJ,PanelWarning;

    private void Start()
    {
        OBJ.SetActive(false);
        PanelWarning.SetActive(false);
    }

    void Update()
    {
        if (SommaScript.GetSomma() > 10)
        {
            OBJ.SetActive(true);
            PanelWarning.SetActive(true);
            // Imposta il testo del TextMeshProUGUI con una funzione
            testoTMP.SetText("Attenzione, il muro Potrebbe Crollare!");

        }
        else {
            OBJ.SetActive(false);
            PanelWarning.SetActive(false);
            // Imposta il testo del TextMeshProUGUI con una funzione
            testoTMP.SetText("");
        }
    }
}
