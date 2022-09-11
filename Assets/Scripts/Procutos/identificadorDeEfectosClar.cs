using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //IMPORTANTE!!!!

public class identificadorDeEfectosClar : MonoBehaviour
{
    public bool esSaludable;
    public bool seEjecutaUnaVez;
    public string nombreDeProducto;

    // Start is called before the first frame update
    void Start()
    {

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
                        Tareas.Nueva(1f, GlitchOn);
                        Tareas.Nueva(1.1f, GlitchOff);
                        Tareas.Nueva(1.3f, GlitchOn);
                        Tareas.Nueva(1.5f, GlitchOff);
                        Tareas.Nueva(2f, GlitchOn);
                        Tareas.Nueva(2.3f, GlitchOff);
                        Tareas.Nueva(2.5f, GlitchOn);
                        Tareas.Nueva(2.7f, GlitchOff);
                        Tareas.Nueva(3f, GlitchOn);
                        Tareas.Nueva(3.4f, GlitchOff);
                        Tareas.Nueva(3.6f, GlitchOn);
                    }

                    if (nombreDeProducto == "manzana")
                    {
                        CambiarColor2(GameManager.instance.suelo);

                    }

                }
            }
        }
    }

    void GlitchOff () //ESTA ES LA PANTALLA EN NEGRO
    {
        
        float alpha = Random.Range(0.001f,0.005f); 
        GameManager.instance.corteDeLuz.GetComponent<RawImage>().color = new Color(0,0,0,alpha);

    }
    void GlitchOn () //ESTA ES LA PANTALLA TRANSLUCIDA
    {

        GameManager.instance.corteDeLuz.GetComponent<RawImage>().color = new Color(0, 0, 0, 0);

    }

    void CambiarColor2(GameObject pisito)
    {
        pisito.GetComponent<Renderer>().material.color = Color.red;
    }
}
