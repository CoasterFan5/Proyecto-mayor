using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class puzzleHouseHitbox : MonoBehaviour
{
    public GameObject mainPlayer;
    private static bool trigerable = true;
    private static Vector3 storedPosition;
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(trigerable)
        {
            if(collision.gameObject.tag == "Player")
            {
                SceneManager.LoadScene("Puzzle");
                storedPosition = collision.gameObject.transform.position;
                trigerable = false;

            }
            
        }
    }
    void Start()
    {
        if(!trigerable)
        {
            mainPlayer.transform.position = storedPosition;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
