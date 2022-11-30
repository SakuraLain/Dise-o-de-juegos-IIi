using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bolaControl : MonoBehaviour
{
    public Rigidbody rb;
    public float impulseForce = 3f;

    private bool ignoreNexcollision;

    private void OnCollisionEnter(Collision collision){

        if (ignoreNexcollision){
            return;
        }

        rb.velocity = Vector3.zero;
        rb.AddForce(Vector3.up*impulseForce, ForceMode.Impulse);

        ignoreNexcollision = true;
        Invoke("AllowNextCollision", 0.2f);
    
    }

    private void AllowNextCollision(){
        ignoreNexcollision = false;
    }
}
