using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Create Radial Trigger
public class RadialTrigger : MonoBehaviour
{
    public Transform Player;
    float Radius = 1;

    private void OnDrawGizmos()
    {
        //Gizmos.DrawSphere(transform.position, 0.1f);

        Gizmos.DrawWireSphere(transform.position, Radius);

        Vector2 center = transform.position;

        float dist = Vector2.Distance(center, Player.position);

        if(dist <= Radius)
        {
            Gizmos.color = Color.green;
        }
        else
        {
            Gizmos.color = Color.red;
        }

        Gizmos.DrawLine(center, Player.position);
    }
}
