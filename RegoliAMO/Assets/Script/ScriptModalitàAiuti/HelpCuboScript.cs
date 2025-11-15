using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HelpCuboScript : MonoBehaviour { 


    //Valore associato al regolo
    public int valoreAssociato = 0;
    //Gameobject relativi al punto di partenz e arrivo
    public GameObject ptarrivo, regolo;
    //velocitá dell'animazione
    public float speed;
    //regoli del muro da attiavre,con relativi material e tmp da aggiornare
    public GameObject[] oggettiDaAttivare;
    public TextMeshProUGUI tmpProText;
    public Material[] shaderdacaricare;
    GameObject duplicate;

    void Start()
    {
      
        // Inizializza tutti gli oggetti come non attivati all'inizio
        for (int i = 0; i < oggettiDaAttivare.Length; i++)
        {
            oggettiDaAttivare[i].SetActive(false);
        }
    }

    void Update()
    {
        // Controllo touch.
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Began)
            {
                Ray ray = Camera.main.ScreenPointToRay(touch.position);
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {
                    if (hit.collider.gameObject == gameObject)
                    {
                        // Aggiunge il valore base alla somma
                        TmpProScript.tmpProValue += valoreAssociato;
                        SommaScript.AggiungiValore(valoreAssociato);

                        // Crea una copia dell'oggetto
                        duplicate = Instantiate(regolo, regolo.transform.position + Vector3.right, Quaternion.identity);
                        // Assegna un nome alla copia
                        duplicate.name = "Copia" + regolo.name;
                    }
                }
            }
        }
        // Parte del codice che serve per creare l'animazione con moveforward.
        
            duplicate.transform.position = Vector3.MoveTowards(duplicate.transform.position, ptarrivo.transform.position, speed);

            // Controllo se il duplicato � arrivato al punto di arrivo in caso positivo quello che faccio � attivare attivare i regoli del muro, colorandoli anche
            if (duplicate.transform.position == ptarrivo.transform.position)
            {
                for (int cont = 0; cont < SommaScript.GetSomma(); cont++)

                {
                    oggettiDaAttivare[cont].SetActive(true);
                    oggettiDaAttivare[cont].GetComponent<Renderer>().material = shaderdacaricare[SommaScript.GetSomma() - 1];

                }
                //Disattiva il duplicato
                duplicate.SetActive(false);
                // Distrugge il duplicato dopo un ritardo
                Destroy(duplicate);
            }
        
    }
}
