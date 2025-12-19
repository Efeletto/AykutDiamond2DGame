
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    public float velocity = 1.2f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }


    void Update()
    {
            float move = Input.GetAxisRaw("Horizontal");
            rb.linearVelocity = new Vector2(move * velocity, rb.linearVelocityY);
    }
}
