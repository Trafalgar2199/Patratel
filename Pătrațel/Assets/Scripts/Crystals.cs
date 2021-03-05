using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //used for scene manager
public class Crystals : MonoBehaviour //original
{
    // Start is called before the first frame update
    private Controls player;
    public AudioSource sound;
    public static AudioClip Collectibles;
    void Start()
    {
        player = FindObjectOfType<Controls>();
        Collectibles = Resources.Load<AudioClip>("Collectible");
        sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (player.crystals >= 39)
            SceneManager.LoadScene("Level2");
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {

            player.crystals++;
      
            Destroy(gameObject);
            
            
            
        }
    }
}


