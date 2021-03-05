using System.Collections;
using System.Collections.Generic;
using UnityEngine;

   
public class Hazard : MonoBehaviour
{
    
    // Start is called before the first frame update
    private Controls player;
    public Transform start;
    public GameObject Explode;
    static int hearts; //static so it can be visible in all game objects
 
    void Start()
    {
        hearts = 3;
        player = FindObjectOfType<Controls>();
        GameObject.Find("Life3").SetActive(true);
        GameObject.Find("Life2").SetActive(true);
        GameObject.Find("Life1").SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
           

                     if (hearts == 3)
                        GameObject.Find("Life3").SetActive(false);
                    

                    if (hearts == 2)
                        GameObject.Find("Life2").SetActive(false);
                    if (hearts == 1)
                    {
                        GameObject.Find("Life1").SetActive(false);
                        Invoke("gameover", 1f); //delay before reloading the level

                    }
            --hearts;

            StartCoroutine("respawndelay");
                }



    }

        
    
     void gameover()
    {
        Application.LoadLevel(Application.loadedLevel);
       
     }
    public IEnumerator respawndelay()

    {       
        Instantiate(Explode, player.transform.position, player.transform.rotation);
        player.enabled = false;
        player.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        player.GetComponent<Renderer>().enabled = false;
        yield return new WaitForSeconds(1);
        player.transform.position = start.position;
        player.GetComponent<Renderer>().enabled = true;
        player.enabled = true;

    }
}
