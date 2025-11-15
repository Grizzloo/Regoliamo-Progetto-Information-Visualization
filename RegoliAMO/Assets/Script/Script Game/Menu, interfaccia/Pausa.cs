using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausa : MonoBehaviour
{
     
    public GameObject pauseCanvas;
    public GameObject TARGET;// Canvas che contiene il menu di pausa 


    private void Start()
    {
        pauseCanvas.SetActive(false);
    }

    void Update()
    {
        // Controllo touch
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
                        TARGET.SetActive(false);
                        OnClickMenuButton();
                    }
                }
            }
        }

        // Controllo mouse (opzionale)
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                if (hit.collider.gameObject == gameObject)
                {
                    TARGET.SetActive(false);
                    OnClickMenuButton();
                }
            }
        }
    }
    public void OnClickMenuButton()
    {
        Time.timeScale = 0f;
        pauseCanvas.SetActive(true);

        Time.timeScale = 0f; // Mette il gioco in pausa
    }
    
}
