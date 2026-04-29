using UnityEngine;
using static UnityEditor.Searcher.SearcherWindow.Alignment;

public class Enemy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float moveSpeed = 5.0f;   // <-- Activity 2 prefab conflict target (serialised in prefab)
   

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        

    }

    private void Update()
    {
        if (transform.position.x <= 10.0f)
        {
            rb.linearVelocity = new Vector2(moveSpeed, 0);
        }
        else
        {
            rb.linearVelocity = new Vector2(-moveSpeed, 0);
        }

        
    }
}
