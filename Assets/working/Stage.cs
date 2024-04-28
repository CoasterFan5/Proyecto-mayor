using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage
{
    public string stageInstructions;
    public int winnerNumber;
    public int questionShapeIndex;
    public int answerShapeIndex;
    public Stage(string stageInstructions, int winnerNumber, int questionShapeIndex, int answerShapeIndex)
    {
        this.stageInstructions = stageInstructions;
        this.winnerNumber = winnerNumber;
        this.questionShapeIndex = questionShapeIndex;
        this.answerShapeIndex = answerShapeIndex;
    }
}
