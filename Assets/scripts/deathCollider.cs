using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathCollider : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            player.GetComponent<PlayerMovement>().goToSpawn();
        }
    }
 

    // Update is called once per frame
    void Update()
    {
        
    }
}
