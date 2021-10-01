using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CuartaEscena : MonoBehaviour
{
    void Start()
    { 
    }
    void Update()
    {
    }

    public void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(4);
    }
    public void IniciarJuego()
    {
        
    }
}
