using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SommaScript : MonoBehaviour
{
    // Variabile statica per la somma totale
    private static int SommaValori = 0,save;

    // Riferimento al componente TextMeshPro
    public TextMeshProUGUI tmpProText;

    // Metodo per aggiungere un valore alla somma
    public static void AggiungiValore(int valore)
    {
        SommaValori += valore;
        AggiornaTesto();
    }
    public static void TogliValore()
    {
        SommaValori -= 1;
        AggiornaTesto();
    }

    // Metodo per ottenere il valore corrente della somma
    public static int GetSomma()
    {
        return SommaValori;
    }

    // Metodo per aggiornare il testo di TextMeshPro con il valore corrente di SommaValori
    private static void AggiornaTesto()
    {
        FindObjectOfType<SommaScript>().tmpProText.text = "" + SommaValori; 
    }
    public static void Azzera()
    {
         SommaValori = 0;
        FindObjectOfType<SommaScript>().tmpProText.text = "" + SommaValori;
    }
    public static void FermaA20()
    {
        SommaValori = 20;
        FindObjectOfType<SommaScript>().tmpProText.text = "" + SommaValori;
    }
    public static void salvasomma()
    {
        save = SommaValori;
    }
    public static int getSave()
    {
        return save;
    }
}
