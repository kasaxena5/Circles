using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NozzleController : MonoBehaviour
{
    [Header("Prefabs")]
    [SerializeField] private ProtectiveLineController linePrefab;
    [SerializeField] private FloatReference fuel;

    [Header("Configs")]
    [SerializeField] private float initialFuel;

    private ProtectiveLineController activeLine;
    private bool isKeyDown = false;
    private List<Vector2> points = new();


    void Start()
    {
        fuel.value = initialFuel;
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
            if (fuel.value > 0)
            {
                points.Add(transform.position);
                fuel.value--;
            }

            if(activeLine != null)
                activeLine.SetupLine(points.ToArray());
        }
        else if(Input.GetKeyUp(KeyCode.Space))
        {
            isKeyDown = false;
            points = new List<Vector2>();
        }
    }
}
