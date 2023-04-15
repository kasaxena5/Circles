using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeBehaviour : MonoBehaviour
{
    [Header("Configs")]
    [SerializeField] private float minSpeed;
    [SerializeField] private float maxSpeed;
    private static Vector2 targetPosition = new Vector2(0, 0);
    private float speed;
    
    private void Awake()
    {
        speed = Random.Range(minSpeed, maxSpeed);
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.TryGetComponent<ProtectiveLineController>(out ProtectiveLineController plc))
        {
            plc.Protect();
        }
        Destroy(this.gameObject);
    }
}
