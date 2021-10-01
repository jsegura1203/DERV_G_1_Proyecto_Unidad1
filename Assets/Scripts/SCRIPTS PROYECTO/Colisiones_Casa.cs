using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Colisiones_Casa : MonoBehaviour
{
    public TextMeshProUGUI Txt_puntaje;
    public TextMeshProUGUI Txt_tiempo;

    public int puntaje;
    public int tiempo;
    void Start()
    {
        puntaje = 0;
        tiempo = 60;
        StartCoroutine("Subrutina1");
    }

    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator Subrutina1()
    {
        while (true)
        {
            if (tiempo > 0)
            {
                tiempo--;
                Txt_tiempo.text = tiempo.ToString();
            }
            yield return new WaitForSeconds(1.0f);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        string tag = collision.gameObject.tag;
        Debug.Log("En Colision con :" + name + "   etiqueta: " + tag);

        if (tag.Equals("Lentes"))
        {
            puntaje=100;
            
            Txt_puntaje.text = puntaje.ToString();
        }
    }
}
