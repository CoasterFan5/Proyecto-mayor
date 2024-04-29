using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ShapeManagerExperiment : MonoBehaviour
{

    public GameObject[] shapeHolders;
    public Canvas canvas;
    public TMP_Text textMesh;
    private bool acceptingAnswers = false;
    private int currentStage = 0;
    private Stage[] stages =
    {
        new Stage("Click the green square", 1, 0, 0),
        new Stage("Click the magenta circle", 2, 1, 2)
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
        acceptingAnswers = true;
        currentStage = stageIndex;
        setShapeManagers(stages[stageIndex].questionShapeIndex);
        setInstructionText(stages[stageIndex].stageInstructions);
    }

    void setInstructionText(string text) {
        textMesh.text = text;
    }

    void setShapeManagers(int shapeIndex)
    {
        for (int i = 0; i < shapeHolders.Length; i++)
        {
            ShapeThingChanger scirpt = shapeHolders[i].GetComponent<ShapeThingChanger>();
            scirpt.setShape(shapeIndex);
        }
    }

    public void registerAnswerSelection(int answerIndex)
    {
        Debug.Log("Answer Registered");
        if(acceptingAnswers)
        {
            //check if the answer is correct
            if (answerIndex == stages[currentStage].winnerNumber)
            {
                setInstructionText("Correct!");
            } else
            {
                setInstructionText("Close, but not quite");
            }

            for (int i = 0; i < shapeHolders.Length; i++)
            {
                ShapeThingChanger scirpt = shapeHolders[i].GetComponent<ShapeThingChanger>();
                scirpt.setShape(stages[currentStage].answerShapeIndex);
            }
            acceptingAnswers = false;
        } else
        {
            if(currentStage != stages.Length - 1)
            {
                setStage(currentStage + 1);
            }
           
        }
    }
}
