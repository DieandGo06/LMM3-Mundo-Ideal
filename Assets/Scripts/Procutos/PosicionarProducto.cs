using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosicionarProducto : MonoBehaviour
{
    Transform posicionInicial;
    Transform nuevaPosicion;
    public bool esAgarrable;



    private void Awake()
    {
        if (transform.parent != null)
        {
            posicionInicial = transform.parent.transform;
        }    
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Espacio"))
        {
            if (other.transform != posicionInicial)
            {
                nuevaPosicion = other.transform;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Espacio"))
        {
            if (other.transform != posicionInicial)
            {
                nuevaPosicion = null;
            }
        }
    }

    public void Posicionar()
    {
        if (nuevaPosicion == null)
        {
            transform.parent = posicionInicial;
            transform.localPosition = Vector3.zero;
        } 
        else
        {
            transform.parent = nuevaPosicion;
            transform.localPosition = nuevaPosicion.position;
        }
   
    }
}
