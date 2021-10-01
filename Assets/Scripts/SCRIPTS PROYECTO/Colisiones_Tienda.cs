using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Colisiones_Tienda : MonoBehaviour
{
    public TextMeshProUGUI Txt_puntaje;
    public TextMeshProUGUI Txt_tiempo;

    public int puntaje;
    public int tiempo;
    void Start()
    {
        puntaje = 0;
        tiempo = 50;
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
        if (tag.Equals("Puntos"))
        {
            puntaje+=20;
            Txt_puntaje.text = puntaje.ToString();
            Txt_puntaje.color = Color.yellow;
        }
        else if (tag.Equals("Tiempo"))
        {

            tiempo += 5;
            Txt_tiempo.text = tiempo.ToString();
            Txt_tiempo.color = Color.green;
        }
        
    }
}
