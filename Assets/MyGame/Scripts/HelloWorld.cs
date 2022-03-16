using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PrintHelloWorld();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Methode mit Debug Log "Hello World"

    private void PrintHelloWorld()
    {
        Debug.Log("HelloWorld");
    }
}
