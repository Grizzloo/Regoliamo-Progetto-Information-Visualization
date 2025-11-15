using TMPro;
using UnityEngine;

public class CuboScript : MonoBehaviour
{
    public ColoreManager regoliManager;
    public int valoreAssociato;
    public GameObject ptarrivo, regolo;
    public float speed;
    private GameObject duplicate;
    private int somma;

    void Update()
    {
        // Controllo touch.
        ControlloTouch();

        // Parte del codice che serve per creare l'animazione con moveforward.
        if (duplicate != null)
        {
            duplicate.transform.position = Vector3.MoveTowards(duplicate.transform.position, ptarrivo.transform.position, speed);
            // Controllo se il duplicato è arrivato al punto di arrivo in caso positivo quello che faccio è attivare attivare i regoli del muro, colorandoli anche
            if (duplicate.transform.position == ptarrivo.transform.position)
            {
                AnimationAndSpawn();
            }
        }
        //Controllo per disattivare i regoli nel caso della rimozione del singolo regolo.
        if (SommaScript.GetSomma() < somma)
        {
            regoliManager.ControlloSomma();
        }
        //Controllo per fermare la somma a massimo 20.
        if (SommaScript.GetSomma() >= 20)
        {
            SommaScript.FermaA20();
        }
    }

    private void AnimationAndSpawn()
    {
        duplicate.SetActive(false);
        Destroy(duplicate);
        regoliManager.ColoraRegoli(valoreAssociato, SommaScript.GetSomma());
         Invoke("color", 4f);
        
    }


    private void ControlloTouch()
    {

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
                        SommaScript.AggiungiValore(valoreAssociato);
                        // mi salvo il valore della somma ogni volta che premo un regolo, cosi facendo nel caso di
                        // sottrazione faccio partire l'if di controllo in update
                        somma = SommaScript.GetSomma();
                        // Crea una copia dell'oggetto e  Assegna un nome alla copia
                        duplicate = Instantiate(regolo, regolo.transform.position + Vector3.right, Quaternion.identity);
                        duplicate.name = "Copia" + regolo.name;
                    }
                }
            }
        }
    }

    void color()
    {
        regoliManager.ColoraInBlocco();
    }
}