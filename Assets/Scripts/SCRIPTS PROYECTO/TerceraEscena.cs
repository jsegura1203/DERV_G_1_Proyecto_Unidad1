using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TerceraEscena : MonoBehaviour
{
    void Start()
    { 
    }
    void Update()
    {
    }

    public void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(3);
    }
    public void IniciarJuego()
    {
        
    }
}
