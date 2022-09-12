using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //IMPORTANTE!!!!

public class identificadorDeEfectosClar : MonoBehaviour
{
    public bool esSaludable;
    public bool seEjecutaUnaVez;
    public string nombreDeProducto;
    private float aparecer;
    private float aparecer1;
    
    
    

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
                        Tareas.NuevaConDuracion(0, 4, AparecerParedSucia);
                        


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
                        

                    }

                }
            }
        }
    }

    void GlitchOff () //ESTA ES LA PANTALLA EN NEGRO
    {
        
        float alpha = Random.Range(0.003f,0.008f); 
        GameManager.instance.corteDeLuz.GetComponent<RawImage>().color = new Color(0,0,0,alpha);

    }
    void GlitchOn () //ESTA ES LA PANTALLA TRANSLUCIDA
    {

        GameManager.instance.corteDeLuz.GetComponent<RawImage>().color = new Color(0, 0, 0, 0);

    }

    void AparecerParedSucia()
    {
        aparecer += Time.deltaTime / 4;
        //float limitador = Mathf.Clamp(aparecer, 0, 1);
        GameObject coso = GameManager.instance.paredes.transform.GetChild(0).gameObject;
        coso.GetComponent<Renderer>().material.color =new Color(1, 1, 1, aparecer);
        Debug.Log("holi");
    }
  
}
