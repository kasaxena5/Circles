using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(LineRenderer))]
[RequireComponent(typeof(EdgeCollider2D))]
public class LineController : MonoBehaviour
{
    private LineRenderer lr;
    private EdgeCollider2D ec2d;
    protected Vector2[] points;

    private void Awake()
    {
        lr = this.GetComponent<LineRenderer>();
        ec2d = this.GetComponent<EdgeCollider2D>();
    }

    public void SetupLine(Vector2[] points)
    {
        lr.positionCount = points.Length;
        this.points = points;
        ec2d.points = points;
    }

    void Update()
    {
        for (int i = 0; i < points.Length; i++)
        {
            lr.SetPosition(i, points[i]);
        }
    }
}