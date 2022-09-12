using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosicionarProducto : MonoBehaviour
{
    [SerializeField] GameObject espacioVacio;
    public Transform gondolaPosition;
    public Transform carritoPosition;
    Quaternion rotacionInicial;



    private void Awake()
    {
        rotacionInicial = transform.rotation;
        if (espacioVacio != null) CrearEspacioVacioInicial();
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("GondolaSpace"))
        {
            gondolaPosition = other.transform;
        }
        if (other.CompareTag("Carrito"))
        {
            if (other.transform.GetComponent<CarritoManager>() != null)
            {
                carritoPosition = other.transform.GetComponent<CarritoManager>().GetEmptySpace().transform;
            }
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Carrito"))
        {
            if (other.transform.GetComponent<CarritoManager>() != null)
            {
                carritoPosition = other.transform.GetComponent<CarritoManager>().GetEmptySpace().transform;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Carrito"))
        {
            carritoPosition = null; 
        }
    }



    //Se ejecuta en el script PlayerAction
    public void SetNewPosition()
    {
        //Si no esta dentro de la colision del carrito
        if (carritoPosition == null)
        {
            //Si toco alguna gondola Space vacio
            if (gondolaPosition != null)
            {
                transform.parent = gondolaPosition;
            }
        }
        //Si tiene asignada una posicion en el carrito
        else
        {
            transform.tag = "Comprado";
            transform.parent = carritoPosition;
        }
        transform.rotation = rotacionInicial;
        float posY = transform.parent.localScale.y;
        transform.localPosition = new Vector3(0, posY, 0);
    }

    void CrearEspacioVacioInicial()
    {
        GameObject espacioVacioInicial = Instantiate(espacioVacio, transform.position, Quaternion.identity);
        espacioVacioInicial.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        gondolaPosition = espacioVacioInicial.transform;
        transform.parent = espacioVacioInicial.transform;
    }
}
