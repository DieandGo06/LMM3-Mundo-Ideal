using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //IMPORTANTE!!!!

public class identificadorDeEfectos : MonoBehaviour
{
    public bool esSaludable;
    public bool seEjecutaUnaVez;
    public string nombreDeProducto;

    // Start is called before the first frame update
    void Start()
    {
        //GlitchOff();
    }

    // Update is called once per frame
    void Update()
    {
        if (!seEjecutaUnaVez)
        {
            if (transform.parent != null)
            {
                if (transform.parent.tag == "CarritoSpace")
                {
                    seEjecutaUnaVez = true;

                    if (nombreDeProducto == "papitas")
                    {
                        //ACA LE DETERMINO EN QUE SEGUNDO LUEGO DE TOMAR EL EFECTO TIENE QUE PRENDERSE Y APAGARSE LA LOooz!!
                        Tareas.Nueva(0.5f, GlitchOff);
                        Tareas.Nueva(0.7f, GlitchOn);
                        Tareas.Nueva(0.9f, GlitchOff);
                        Tareas.Nueva(0.99f, GlitchOn);
                        Tareas.Nueva(1.2f, GlitchOff);
                        Tareas.Nueva(1.29f, GlitchOn);
                        Tareas.Nueva(1.4f, GlitchOff);
                        Tareas.Nueva(1.5f, GlitchOn);
                        Tareas.Nueva(1.8f, GlitchOff);
                        Tareas.Nueva(1.95f, GlitchOn);
                        Tareas.Nueva(2.0f, GlitchOff);
                        Tareas.Nueva(2.09f, GlitchOn);

                    }

                    if (nombreDeProducto == "manzana")
                    {
                        CambiarColor2(GameManager.instance.suelo);

                    }

                    if (nombreDeProducto == "coquita")
                    {
                        AcelerarCarrito();
                        Tareas.Nueva(5, RalentizarCarrito);
                    }

                }
            }
        }
    }

    void CambiarColorPiso (GameObject pisito)
    {
        pisito.GetComponent<Renderer>().material.color = Color.red;
        
    }

    void CambiarColor2(GameObject pisito)
    {
        pisito.GetComponent<Renderer>().material.color = Color.black;
    }

    void RalentizarCarrito()
    {
        GameManager.instance.jugador.GetComponent<PlayerMovement>().speed = 2;
    }

    void AcelerarCarrito()
    {
        GameManager.instance.jugador.GetComponent<PlayerMovement>().speed = 20;
    }

    void GlitchOff() //ESTA ES LA PANTALLA EN NEGRO
    {

        float alpha = Random.Range(0.85f, 0.95f);
        GameManager.instance.corteDeLuz.GetComponent<RawImage>().color = new Color(0, 0, 0, alpha);
        Debug.Log("esta funcionando");

    }
    void GlitchOn() //ESTA ES LA PANTALLA TRANSLUCIDA
    {

        GameManager.instance.corteDeLuz.GetComponent<RawImage>().color = new Color(0, 0, 0, 0);

    }
}
