using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Create Radial Trigger
public class RadialTrigger : MonoBehaviour
{
    public Transform A, B;

    public float aLength;

    private void OnDrawGizmos()
    {
        //Gizmos.DrawSphere(transform.position, 0.1f);
        Vector2 a = A.position;
        Vector2 b = B.position;

        Gizmos.color = Color.cyan;
        Gizmos.DrawLine(default, a);
        

        aLength = Mathf.Sqrt((a.x * a.x) + (a.y * a.y));

        float bLength = Mathf.Sqrt((b.x * b.x) + (b.y * b.y));

        if(bLength <= aLength)
        {
            Gizmos.color = Color.green;
        }
        else
        {
            Gizmos.color = Color.red;
        }

        
        Gizmos.DrawLine(default, b);



    }
}
