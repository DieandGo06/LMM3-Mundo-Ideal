using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorSonidoPrueba : MonoBehaviour
{
    [SerializeField] AudioSource fuenteRoja;
    [SerializeField] AudioSource fuenteAzul;
    [SerializeField] AudioSource fuenteVerde;
    [SerializeField] AudioSource fuenteNaranja;

    [Space(10)]
    [SerializeField] GameObject padreFuentesDeSonido;
    [SerializeField] float velocidadDeGiro;
    [SerializeField] bool sigueGirando;


    private void Update()
    {
        if (sigueGirando)
        {
            if (velocidadDeGiro == 0) velocidadDeGiro = 0.3f;
            padreFuentesDeSonido.transform.Rotate(0, velocidadDeGiro, 0);
        }
    }


    public void PlayRojo()
    {
        fuenteRoja.PlayOneShot(fuenteRoja.clip);
    }
    public void PlayAzul()
    {
        fuenteAzul.PlayOneShot(fuenteAzul.clip);
    }
    public void PlayVerde()
    {
        fuenteVerde.PlayOneShot(fuenteVerde.clip);
    }
    public void PlayNaranja()
    {
        fuenteNaranja.PlayOneShot(fuenteNaranja.clip);
    }

    public void ActivarDesactivarGiro()
    {
        sigueGirando = !sigueGirando;
    }
}
