using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Touch : MonoBehaviour
{ 
    private Controls player;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<Controls>();
    }

    // Update is called once per frame

    public void LeftArrow()
    {
        player.moveright = false;
        player.moveleft = true;

    }
    public void RightArrow()
    {
        player.moveright = true;
        player.moveleft = false;

    }
    public void RealeaseLeftArrow()
    {
        player.moveleft = false;
    }
    public void RealeaseRightArrow()
    {
        player.moveright = false;
    }
    public void Jump()
    {
        player.jump = true;
    }
    void Update()
    {
        
    }
}
