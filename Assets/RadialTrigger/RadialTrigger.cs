using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Create Radial Trigger
public class RadialTrigger : MonoBehaviour
{
    public Transform Player;
    public float Radius = 1;

    private void OnDrawGizmos()
    {
        Vector3 center = transform.position;
        Vector3 playerPos = Player.position;

        Vector3 d = center - playerPos;

        //float dist = d.magnitude;
        //float dist = Vector3.Distance(center, playerPos);

        //float sqrtDist = ((d.x * d.x) + (d.y * d.y) + (d.z * d.z));
        float sqrtDist = Vector3.Dot(d,d);

        
        //bool inSide = dist <= Radius;
        bool inSide = sqrtDist <= Radius * Radius;
        Gizmos.color = inSide ? Color.green : Color.red;


        Gizmos.DrawWireSphere(center, Radius);

    }
}
