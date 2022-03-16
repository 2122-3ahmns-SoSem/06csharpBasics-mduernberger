using UnityEngine;

public enum Himmelsrichtungen
{
    Nord,
    Sued,
    West,
    Ost
}

public class Variablen : MonoBehaviour
{
    Color farbe;
    int anzTueren;
    int anzTueren2;
    int anzTueren3;
    string yourName;

    //Ich habe gemeinsam Laura Forsthuber und Sophe Kloiber gearbeitet :)

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(Himmelsrichtungen.Nord + " " + Himmelsrichtungen.Sued + " " + Himmelsrichtungen.West + " " + Himmelsrichtungen.Ost);

        //Personen persoenlich ansprechen
        yourName = "du da!";
        Debug.Log("Hallo " + yourName);

        //Werte berechnen
        anzTueren = 12;
        anzTueren2 = 2;
        anzTueren3 = 22;
        Debug.Log(anzTueren + anzTueren2 + anzTueren3);

        //Farbe aendern
        farbe = Color.red;
        Debug.Log(farbe);
        gameObject.GetComponent<Renderer>().material.color = farbe;

        //Groessenvergleiche
        Debug.Log(anzTueren < anzTueren2);

       
    }

}