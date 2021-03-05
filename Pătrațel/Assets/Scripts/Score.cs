using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour //original
{
    // Start is called before the first frame update
    Text text;
    private Controls player;
    void Start()
    {
        text = GetComponent<Text>();
        player = FindObjectOfType<Controls>();
        //text=GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        text.text = "Crystals: " + player.crystals+" / 40"; ;
    }
}
