using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerRotationOnCanvas : MonoBehaviour
{
    public Transform player;
    Text textDisplay;


    // Start is called before the first frame update
    void Start()
    {
        textDisplay = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        textDisplay.text = player.rotation.ToString();
    }
}
