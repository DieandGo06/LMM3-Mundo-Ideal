using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Caminante : MonoBehaviour
{
    [SerializeField] float speed;
    Rigidbody rb;
    bool seMueve;
    public float tiempoMax;
    float tiempoTranscurrido;
    // Start is called before the first frame update

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();

    }
    void Start()
    {
        seMueve = true;
        speed = 2;
    }

    // Update is called once per frame
    void Update()
    {
        tiempoTranscurrido += Time.deltaTime;

        if (seMueve) Marcar();

        if (tiempoTranscurrido > tiempoMax)  Detener();
        
    }

    void Marcar()
    {
        transform.position = transform.position + Vector3.right * speed * Time.deltaTime;

    }

    void Detener()
    {
        seMueve = false;
    }

    // Para activar caminante en el script de la lista = gameObject.SetActive(false);

}
