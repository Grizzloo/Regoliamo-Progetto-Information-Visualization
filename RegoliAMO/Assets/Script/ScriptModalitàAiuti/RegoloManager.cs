using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class RegoloManager : MonoBehaviour {
    public int numeroRegoli; // Numero totale di regoli
    public int[] ordineRegoli; // Sequenza corretta dei regoli da attivare
    public GameObject conferma;
    int conta = 0;

    public Material materiale;
    public GameObject[] regoli; // Array di GameObject che rappresentano i regoli
     private void Start(){
        conferma.SetActive(false);   
     }

    private void Update() {
        if (SommaScript.GetSomma()==10) { 
            conferma.SetActive(true);   
        }
        for(int i = 0; i < numeroRegoli; i++) {
            if(SommaScript.GetSomma() + ordineRegoli[i] > 10) {
                conta++;
               TextMeshProUGUI textMeshPro = regoli[i].GetComponentInChildren<TextMeshProUGUI>();
                // Imposta il colore del testo su nero
                 textMeshPro.color = Color.black;
                regoli[i].GetComponent<Renderer>().material = materiale;
                regoli[i].GetComponent<Collider>().enabled = false;
                // Disabilita il collider del regolo
                Collider collider = regoli[i].GetComponent<Collider>();
                if (collider != null) {
                    collider.enabled = false;
                }

            }
        }
       
    }
}