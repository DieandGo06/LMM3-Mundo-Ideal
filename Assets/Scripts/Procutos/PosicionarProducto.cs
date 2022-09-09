using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PosicionarProducto : MonoBehaviour
{
    public Transform gondolaPosition;
    public Transform carritoPosition;



    private void Awake()
    {
        if (transform.parent != null)
        {
            gondolaPosition = transform.parent.transform;
        }
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("GondolaSpace"))
        {
            gondolaPosition = other.transform;
        }
        if (other.CompareTag("CarritoSpace"))
        {
            carritoPosition = other.transform;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("CarritoSpace"))
        {
            carritoPosition = null;
        }
    }

    public void DarPosicionFija()
    {
        if (carritoPosition == null)
        {
            transform.parent = gondolaPosition;
            transform.rotation = Quaternion.Euler(Vector3.zero);
            //float posY = (transform.localScale.y / 2) - (transform.parent.localScale.y / 2);
            float posY = transform.parent.localScale.y;
            transform.localPosition = new Vector3(0, posY, 0);
        }
        else
        {
            transform.tag = "Comprado";
            transform.parent = carritoPosition;
            transform.rotation = Quaternion.Euler(Vector3.zero);
            float posY = transform.parent.localScale.y;
            transform.localPosition = new Vector3(0, posY, 0);
        }

    }
}
