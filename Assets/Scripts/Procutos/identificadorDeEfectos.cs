using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class identificadorDeEfectos : MonoBehaviour
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
                        CambiarColorPiso(GameManager.instance.suelo);
                      
                    }

                    if (nombreDeProducto == "manzana")
                    {
                        CambiarColor2(GameManager.instance.suelo);

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
}
