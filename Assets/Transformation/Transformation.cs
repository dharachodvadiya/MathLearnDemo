using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transformation : MonoBehaviour
{
    [Header("World To Local")]
    public Vector2 WorldPos;
    [Header("Result of World To Local (Do not change)")]
    public Vector2 resultLocalPos;
    [Header("Local To World (Cyan)")]
    public Vector2 LocalPos;
    private void OnDrawGizmos()
    {
        //Local to world
        Gizmos.color = Color.cyan;
        Vector2 wPos = localToWorld(LocalPos);
        Gizmos.DrawSphere(wPos, 0.1f);

        //world to local
        Gizmos.color = Color.blue;
        resultLocalPos = worldToLocal(WorldPos);
        Gizmos.DrawSphere(WorldPos, 0.1f);
    }

    public Vector2 worldToLocal(Vector2 world)
    {
        Vector2 rel = world - (Vector2)transform.position;
        float x = Vector2.Dot(rel, transform.right);
        float y = Vector2.Dot(rel, transform.up);
        return new(x,y);
    }

    public Vector2 localToWorld(Vector2 local)
    {
        Vector2 pos = transform.position;
        pos += (Vector2)transform.right * local.x;
        pos += (Vector2)transform.up * local.y;
        return pos;
    }
}
