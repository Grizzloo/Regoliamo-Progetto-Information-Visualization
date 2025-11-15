using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColoreManager : MonoBehaviour
{
    public Material[] shaderDaCaricare;
    public GameObject[] regoli;
    private int x = 0;

    private void Start()
    {
        // Ottieni tutti i regoli dal GameObject padre
        for (int i = 0; i < regoli.Length; i++)
        {
            regoli[i].SetActive(false);
        }
    }
    public void ColoraRegoli(int valoreAssociato, int numRegoliDaColorare)
    {
        // Applica il materiale corrispondente ai regoli fino al numero specificato
        for (int i = x; i < numRegoliDaColorare; i++)
        {
            regoli[i].SetActive(true);
            regoli[i].GetComponent<Renderer>().material = shaderDaCaricare[valoreAssociato - 1];
            x++;
        }
        Setx(x);
    }
    public void ColoraInBlocco()
    {
        for (int i = 0; i < SommaScript.GetSomma(); i++)
        {
            regoli[i].GetComponent<Renderer>().material = shaderDaCaricare[SommaScript.GetSomma() - 1];

        }

    }
    private void Setx(int x)
    {
        this.x = x;
    }

    public void ControlloSomma()
    {
       

        // Se la somma è uguale a 0
        if (SommaScript.GetSomma() == 0)
        {
            // Reimposta il materiale del primo regolo
            regoli[0].GetComponent<Renderer>().material = shaderDaCaricare[0];

            // Disattiva il primo regolo
            regoli[0].SetActive(false);

            // Ripristina l'indice
            x = 0;
        }
        else
        {
            // Se la somma è diminuita
            if (SommaScript.GetSomma() < x)
            {
                // Scorri i regoli attivi
                for (int i = SommaScript.GetSomma(); i < x; i++)
                {
                    // Disattiva i regoli in eccesso
                    regoli[i].GetComponent<Renderer>().material = shaderDaCaricare[SommaScript.GetSomma()-1];
                    regoli[i].SetActive(false);
                  //  regoli[i].GetComponent<Renderer>().material = shaderDaCaricare[SommaScript.GetSomma()];
                }
                // Ripristina l'indice
                x = SommaScript.GetSomma();
               
            }

            for (int i = 0; i < SommaScript.GetSomma(); i++)
            {
              
                regoli[i].GetComponent<Renderer>().material = shaderDaCaricare[SommaScript.GetSomma() - 1];
            }
        }
    }

}
