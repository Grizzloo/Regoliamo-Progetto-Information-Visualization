using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ConfermaAiuti : MonoBehaviour
{
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
                            SommaScript.Azzera();
                            SceneManager.LoadScene(4);
                    }
                }
            }
        }
    }

}