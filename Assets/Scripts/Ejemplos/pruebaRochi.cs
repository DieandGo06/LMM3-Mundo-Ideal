using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pruebaRochi : MonoBehaviour
{
    // Start is called before the first frame update
    private PlayerMovement playerMovementsc;
    public bool estaMirando;
    public Vector3 posicionPadre;
    public Transform transformCubito;

    private void Awake()
    {
        playerMovementsc = GetComponent<PlayerMovement>();
    }

    void Start()
    {
        
        playerMovementsc.guaranga = 10;
    }

    // Update is called once per frame
    void Update()
    {
       
       
        if( estaMirando == true)
        {
           posicionPadre = transform.position + new Vector3(0, 0.5f, 2);
           transformCubito.position = posicionPadre;
        }

    }



    private void OnTriggerStay(Collider other)
    {
     

        if (other.transform.tag == "cubito")
        {
            transformCubito = other.transform;
            estaMirando = true;
        }
    }
}
