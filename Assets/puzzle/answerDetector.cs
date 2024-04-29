using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class answerDetector : MonoBehaviour
{
    public GameObject shapeManager;
    public int answerIndex = 0;

    private void OnMouseDown()
    {
        shapeManager.GetComponent<ShapeManagerExperiment>().registerAnswerSelection(answerIndex);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
