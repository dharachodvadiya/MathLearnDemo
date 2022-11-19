using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectionTest : MonoBehaviour
{
    public Transform A, B;

    float dist_a_aling_b;
    private void OnDrawGizmos()
    {
        //Gizmos.DrawSphere(transform.position, 0.1f);
        Vector2 a = A.position;
        Vector2 b = B.position;

        Gizmos.color = Color.red;
        Gizmos.DrawLine(default, a);
        Gizmos.color = Color.cyan;
        Gizmos.DrawLine(default, b);

        //normalizing

        float aLength = Mathf.Sqrt((a.x * a.x) + (a.y * a.y));
        //float aLength = a.magnitude;
        Vector2 aNorm = a / aLength;
        //Vector2 aNorm = a.normalized;
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(aNorm, 0.05f);

        //Scaler projection
        dist_a_aling_b = Vector2.Dot(aNorm,b);

        // Vector projection
        Vector2 vecProj = aNorm * dist_a_aling_b;

        Gizmos.color = Color.white;
        Gizmos.DrawSphere(vecProj, 0.05f);
    }
}
