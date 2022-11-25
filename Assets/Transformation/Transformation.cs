using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transformation : MonoBehaviour
{
    Vector2 WorldPos;
    [Header("Local To World (Cyan)")]
    public Vector2 LocalPos;
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Vector2 wPos = localToWorld(LocalPos);
        Gizmos.DrawSphere(wPos, 0.1f);
    }

    public Vector2 localToWorld(Vector2 local)
    {
        Vector2 pos = transform.position;
        pos += (Vector2)transform.right * local.x;
        pos += (Vector2)transform.up * local.y;
        return pos;
    }
}
