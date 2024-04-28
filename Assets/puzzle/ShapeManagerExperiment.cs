using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeManagerExperiment : MonoBehaviour
{

    public GameObject[] shapeHolders;
    private Stage[] stages =
    {
        new Stage("Click the red square", 2, 0, 0)
    };

    // Start is called before the first frame update
    void Start()
    {
        setStage(0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void setStage(int stageIndex)
    {
        setShapeManagers(stages[stageIndex].questionShapeIndex);
    }

    void setShapeManagers(int shapeIndex)
    {
        for (int i = 0; i < shapeHolders.Length; i++)
        {
            ShapeThingChanger scirpt = shapeHolders[i].GetComponent<ShapeThingChanger>();
            scirpt.setShape(shapeIndex);
        }
    }
}
