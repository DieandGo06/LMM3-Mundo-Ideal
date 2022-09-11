using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject suelo;
    public GameObject jugador;
    public RawImage corteDeLuz;

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
