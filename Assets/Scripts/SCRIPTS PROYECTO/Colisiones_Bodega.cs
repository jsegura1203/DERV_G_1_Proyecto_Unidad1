using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Colisiones_Bodega : MonoBehaviour
{
    public TextMeshProUGUI Txt_puntaje;
    public TextMeshProUGUI Txt_tiempo;

    public int puntaje;
    public int tiempo;
    void Start()
    {
        puntaje = 0;
        tiempo = 90;
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
            if (tiempo > 0 && puntaje==0)
            {
                tiempo--;
                Txt_tiempo.text = tiempo.ToString();
                Txt_tiempo.color = Color.white;
                Txt_puntaje.color = Color.white;
            }
            yield return new WaitForSeconds(1.0f);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        string tag = collision.gameObject.tag;
        Debug.Log("En Colision con :" + name + "   etiqueta: " + tag);

        if (tag.Equals("Tiempo"))
        {
            if(puntaje==0)
            {
                tiempo += 5;
                Txt_tiempo.text = tiempo.ToString();
                Txt_tiempo.color = Color.green;
            }
        }
        else
        {
            if (tag.Equals("Hijos"))
            {
                if (puntaje==0)
                {
                    puntaje = 100;
                    Txt_puntaje.text = puntaje.ToString();
                    Txt_puntaje.color = Color.yellow;
                }
            }
        }
    }
}
