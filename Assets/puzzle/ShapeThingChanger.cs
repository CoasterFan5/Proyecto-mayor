using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeThingChanger : MonoBehaviour
{
    public GameObject[] shapeList;
    public string shapeSortingLayer = "Super Foreground";
    private GameObject cloned;
    private bool activeClone = false;

    public float posX = 0;
    public float posY = 0;
    public float posZ = 0;
    public float scale = 1;
    // Start is called before the first frame update
    void Start()
    {
        ThreeShapeManager.openNewShapes();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        ThreeShapeManager.resolveWarnings();
        if (ThreeShapeManager.doNewShapes())
        {
            Debug.Log("Create new shape!");
            ThreeShapeManager.addWarning();
        }
    }

    public void setShape(int shapeIndex)
    {   
        if(activeClone)
        {
            Destroy(cloned);
            activeClone = false;
        }
        GameObject randomShape = shapeList[shapeIndex];
        cloned = Instantiate(randomShape);
        cloned.GetComponent<SpriteRenderer>().sortingLayerName = shapeSortingLayer;
        cloned.transform.position = new Vector3(posX, posY, posZ);
        cloned.transform.localScale = new Vector3(scale, scale, scale);
        activeClone=true;
        
    }
}
