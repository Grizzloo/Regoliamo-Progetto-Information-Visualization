using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Conferma : MonoBehaviour
{
    public Rigidbody[] regoliRigidbody;
    private void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // Controllo touch
        ControlloTouch();
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
                        
                        if (SommaScript.GetSomma() == 10)
                        {
                            SommaScript.Azzera();
                            SceneManager.LoadScene(4);
                        }
                        else { 
                                // Fai cadere i regoli
                                foreach (Rigidbody regoloRigidbody in regoliRigidbody)
                                {
                                    regoloRigidbody.isKinematic = false; // Attiva la fisica
                                    regoloRigidbody.AddForce(Vector3.down * 0.2f, ForceMode.Impulse); // Applica una forza verso il basso
                                }
                                Invoke("LoadSceneAfterDelay", 1f);
                            }
                    }
                }
            }
        }
    }

    void LoadSceneAfterDelay()
    {
        SommaScript.salvasomma();
        SommaScript.Azzera();
        SceneManager.LoadScene(3);
    }
}
