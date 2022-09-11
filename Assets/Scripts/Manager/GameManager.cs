using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public GameObject suelo;

    // private int limiteDeFps = 30;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
     //   Application.targetFrameRate = limiteDeFps;
    }
}
