using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OctavaEscena : MonoBehaviour
{
    void Start()
    { 
    }
    void Update()
    {
    }

    public void OnTriggerEnter(Collider other)
    {
        string name = other.gameObject.name;
        Debug.Log(name);
        if(name.Equals("Player"))
            SceneManager.LoadScene(8);
    }
    public void IniciarJuego()
    {
        
    }
}
