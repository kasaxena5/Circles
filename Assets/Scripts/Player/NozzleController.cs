using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NozzleController : MonoBehaviour
{
    [Header("Prefabs")]
    [SerializeField] private LineController linePrefab;

    private LineController activeLine;
    private bool isKeyDown = false;
    private List<Vector2> points = new();


    void Start()
    {
    }

    void Update()
    {
        if(Input.GetKey(KeyCode.Space))
        {
            if(isKeyDown == false)
            {
                activeLine = Instantiate(linePrefab);
                isKeyDown = true;
            }
            points.Add(transform.position);
            activeLine.SetupLine(points.ToArray());

        }
        else if(Input.GetKeyUp(KeyCode.Space))
        {
            isKeyDown = false;
            points = new List<Vector2>();
        }
    }
}
