using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControl : MonoBehaviour
{
    public bolaControl ball;

    private float offset;
    // Start 
    void Start()
    {
        offset = transform.position.y - ball.transform.position.y;
        
    }

    // Update 
    void Update()
    {
        Vector3 actualPos = transform.position;
        actualPos.y = ball.transform.position.y + offset;
        transform.position = actualPos;
    }
}
