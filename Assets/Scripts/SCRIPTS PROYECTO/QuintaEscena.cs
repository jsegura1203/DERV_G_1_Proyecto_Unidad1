using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuintaEscena : MonoBehaviour
{
    void Start()
    { 
    }
    void Update()
    {
    }

    public void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(5);
    }
    public void IniciarJuego()
    {
        
    }
}
