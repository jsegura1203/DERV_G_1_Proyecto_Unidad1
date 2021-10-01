using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscenaTrigger : MonoBehaviour
{
    void Start()
    { 
    }
    void Update()
    {
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Uso de Triggger");
        SceneManager.LoadScene(1);
    }
}
