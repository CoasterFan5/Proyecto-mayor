using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CameraFollow : MonoBehaviour
    
{
    public GameObject toFollow;
    void Update()
    {
        float xClamped = Mathf.Clamp(toFollow.transform.position.x, -8.5f, 8f);
        gameObject.transform.SetPositionAndRotation(new Vector3(xClamped, gameObject.transform.position.y, gameObject.transform.position.z), gameObject.transform.rotation);
    }
}
