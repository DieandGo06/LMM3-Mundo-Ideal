using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //IMPORTANTE!!!!

public class identificadorDeEfectosClar : MonoBehaviour
{
    public bool esSaludable;
    public bool seEjecutaUnaVez;
    public bool seEjecutaUnaConstante;
    public string nombreDeProducto;

    private float aparecer;

    //Para el temporizador de las paredes
   
    float tiempoTranscurrido;
    bool apareciendoSucia;
    bool apareciendoLimpia;
    [SerializeField] float speed;



    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        if (!seEjecutaUnaConstante) //PAREDES-------------------------------------------------------------------------
        {

            if (tiempoTranscurrido < 1 && apareciendoSucia == true || tiempoTranscurrido < 1 && apareciendoLimpia == true)
            {
                if (apareciendoSucia == true)
                {
                    //tiene que desaparecr el otro
                    GameManager.instance.paredes.transform.GetChild(1).gameObject.SetActive(false);
                   
                    AparecerParedSucia();
                }
                if (apareciendoLimpia == true)
                {
                    //tiene que desaparecr el otro
                    GameManager.instance.paredes.transform.GetChild(0).gameObject.SetActive(false);
                    
                    AparecerParedLimpia();
                }
            }
            else
            {
                
                seEjecutaUnaConstante = false;
            }
        }
        




        if (!seEjecutaUnaVez)
        {
            if (transform.parent != null)
            {
                if (transform.parent.tag == "CarritoSpace")
                {
                    seEjecutaUnaVez = true;

                    if (nombreDeProducto == "galletitas") //Las galletitas generan el glitch en la luz
                    {

                        //Aparece la pared
                        //apareciendoSucia = true; !!!!!!!!!! en esta entrega no usamos pared sucia, solo limpia
                       // GameManager.instance.paredes.transform.GetChild(0).gameObject.SetActive(true);

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
                        Tareas.Nueva(2.11f, GlitchOff);// aca se queda en off

                    }

                    if (nombreDeProducto == "agua") //El agua mejora el estado de las paredes
                    {
                        apareciendoLimpia = true;
                       
                        GameManager.instance.paredes.transform.GetChild(1).gameObject.SetActive(true);
                       

                    }

                }
            }
        }
    }



    //Paredes ------------------------------------------
    void AparecerParedSucia()
    {
        float segundos = 4;
        tiempoTranscurrido += Time.deltaTime/segundos;
        GameObject coso = GameManager.instance.paredes.transform.GetChild(0).gameObject;
        coso.GetComponent<Renderer>().material.color = new Color(1, 1, 1, tiempoTranscurrido);

        
    }

    void AparecerParedLimpia()
    {
        float segundos = 4;
        tiempoTranscurrido += Time.deltaTime / segundos;
        GameObject coso = GameManager.instance.paredes.transform.GetChild(1).gameObject;
        coso.GetComponent<Renderer>().material.color = new Color(1, 1, 1,tiempoTranscurrido);


    }


    //Luces -----------------------------------------------------------------------------------------
    void GlitchOff () //ESTA ES LA PANTALLA EN NEGRO------------------------------------------------
    {
        
        float alpha = Random.Range(0.003f,0.005f); 
        GameManager.instance.corteDeLuz.GetComponent<RawImage>().color = new Color(0,0,0,alpha);

    }
    void GlitchOn () //ESTA ES LA PANTALLA TRANSLUCIDA
    {

        GameManager.instance.corteDeLuz.GetComponent<RawImage>().color = new Color(0, 0, 0, 0);

    }

    

   

}
