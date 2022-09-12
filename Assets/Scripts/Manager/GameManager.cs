using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering.Universal;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    
    [Header("Variables Principales")]
    public GameObject jugador;
    public GameObject carrito;

    [Header("Referencias a efectos")]
    public GameObject suelo;
    public GameObject paredes;
    public RawImage corteDeLuz;
    public GameObject globalVolume;

    private int limiteDeFps = 30;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
     Application.targetFrameRate = limiteDeFps;
    }
}
