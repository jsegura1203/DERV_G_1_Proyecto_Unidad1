using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SegundaEscena : MonoBehaviour
{
    void Start()
    { 
    }
    void Update()
    {
    }

    public void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(2);
    }
    public void IniciarJuego()
    {
        
    }
}
