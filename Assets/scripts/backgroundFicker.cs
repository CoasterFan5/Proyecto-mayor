using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backgroundFicker : MonoBehaviour
{

    public GameObject[] backgrounds;
    public int waitTime = 3;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SwapBackground", 0, waitTime);
        SwapBackground();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void SwapBackground()
    {
        Debug.Log("swaping");
        for(int i = 0; i < backgrounds.Length; i++)
        {
            Color color = backgrounds[i].GetComponent<SpriteRenderer>().material.color;
            backgrounds[i].GetComponent<SpriteRenderer>().material.color = new Color(color.r, color.g, color.b, 0);
        }

        int pickedItemIndex = Random.Range(0, backgrounds.Length);
        Color pickedItemColor = backgrounds[pickedItemIndex].GetComponent<SpriteRenderer>().material.color;
        backgrounds[pickedItemIndex].GetComponent<SpriteRenderer>().material.color = new Color(pickedItemColor.r, pickedItemColor.g, pickedItemColor.b, 1);
    }
}
