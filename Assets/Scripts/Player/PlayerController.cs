using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Header("Configs")]
    [SerializeField] private float speed;
    [SerializeField] private float radius;

    private readonly Vector3 pivotAxis = new(0, 0, 1);
    private readonly Vector3 pivotPoint = new(0, 0, 0);

    void Start()
    {
        transform.position = new(radius, 0, 0);
    }

    void Update()
    {
        transform.RotateAround(pivotPoint, pivotAxis, speed * Time.deltaTime);
    }
}
