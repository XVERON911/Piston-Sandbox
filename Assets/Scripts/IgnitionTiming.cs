using UnityEngine;

public class IgnitionTiming : MonoBehaviour
{
    [SerializeField] private Rigidbody2D pistonRB;
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        pistonRB.AddForceY(100, ForceMode2D.Impulse);
        Debug.Log($"Collided With {collision.name}");
    }

    void Update()
    {
        
    }
}
