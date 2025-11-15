using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CheckSbaglio : MonoBehaviour
{
    public TextMeshProUGUI tmpProText;
    // Start is called before the first frame update
    void Start()
    {
        if (SommaScript.getSave() < 10)
        {
            tmpProText.SetText("NON sei riuscito a costruire il muro!");
        }
        else {
            tmpProText.SetText("OH no, hai messo troppi regoli!");
        }
    }
}
