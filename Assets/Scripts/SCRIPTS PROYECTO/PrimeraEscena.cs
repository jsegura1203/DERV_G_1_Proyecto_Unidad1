using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PrimeraEscena : MonoBehaviour
{
    void Start()
    { 
    }
    void Update()
    {
    }
    public void IniciarJuego()
    {
        SceneManager.LoadScene(1);
    }
}
