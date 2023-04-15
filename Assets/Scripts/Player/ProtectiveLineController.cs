using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProtectiveLineController : LineController
{
    [Header("Prefabs")]
    [SerializeField] private IntReference score;
    [SerializeField] private FloatReference fuel;

    public void Protect()
    {
        score.value += 1;
        fuel.value += points.Length;
        Destroy(this.gameObject);
    }
}
