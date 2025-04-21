using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float Speed;  
    public float JumpForce;  
    float move;  

    Rigidbody2D rb2d;  
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();  
    }

    void Update()
    {
        move = Input.GetAxis("Horizontal");  
        
        rb2d.linearVelocity = new Vector2(move * Speed, rb2d.linearVelocity.y);

       
        if (Input.GetButtonDown("Jump"))
        {
            
            rb2d.AddForce(new Vector2(rb2d.linearVelocity.x, JumpForce));
            Debug.Log("Jump!");  
        }
    }
}
