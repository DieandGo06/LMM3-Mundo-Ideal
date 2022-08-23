using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField, Range(1, 10)] float speed;
    CharacterController controller;
    Vector3 velocity;


    private void Awake()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        Gravedad();
        Caminar();
    }

    void Caminar()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");
        //"transform.right" toma la direccion de la flecha en "x" del personaje y "transform.foward" toma la de "z"
        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);
    }

    void Gravedad()
    {
        float fuerza = -9.81f;
        //Formula de velocidad en caida libre (aparentemente): v = (1/2) * g * (t*t)
        velocity.y += fuerza * Mathf.Pow(Time.deltaTime, 2);
        controller.Move(velocity);
    }
}