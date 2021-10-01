using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Colisiones : MonoBehaviour
{
    public TextMeshProUGUI Txt_puntaje;
    public TextMeshProUGUI Txt_tiempo;

    public int puntaje;
    public int tiempo;
    void Start()
    {
        puntaje = 0;
        tiempo = 100;
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
        string name = collision.gameObject.name;
        string tag = collision.gameObject.tag;
        Debug.Log("En Colision con :" + name + "   etiqueta: " + tag);

        if (tag.Equals("Puntos"))
        {
            puntaje+=10;
            Txt_puntaje.text = puntaje.ToString();
            GameObject gameobj = GameObject.Find(name);
            Destroy(gameobj);
        }
        else if (tag.Equals("Tiempo"))
        {

            tiempo += 10;
            Txt_tiempo.text = tiempo.ToString();
            GameObject gameobj = GameObject.Find(name);
            Destroy(gameobj);

        }
    }
}
