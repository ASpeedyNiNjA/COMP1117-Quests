using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    //Variables from PlayerStats.cs
    private PlayerStats stats;

    //Field Variables
    private Vector2 moveInput;
  
    //Components
    private Rigidbody2D rBody; //Field Variable

    //Sidequest 1
    public ParticleSystem landExplosion;

    //Sidequest 2
    public bool superSpeed = false;


    void Awake()
    {
        // Initialize
        rBody = GetComponent<Rigidbody2D>();
        stats = new PlayerStats();
        int something = stats.MoveSpeed;

    }

    void FixedUpdate()
    {
        if(superSpeed == true)
        {
            SuperMovement();
        }
        else
        {
            ApplyMovement();
        }
    }

    //Method Declarations
    void ApplyMovement()
    {
      float velocityX = moveInput.x;

    rBody.linearVelocity = new Vector2(velocityX, rBody.linearVelocity.y);
    }
    void SuperMovement()
    {
        float velocityX = moveInput.x;

        rBody.linearVelocity = new Vector2(velocityX * 5, rBody.linearVelocity.y);
    }
    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //Sidequest 1
        if (collision.gameObject.CompareTag("Ground"))
        {
            landExplosion.Play();
        }       

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Sidequest 2
        if (collision.gameObject.name == "Collectable")
        {
            superSpeed = true;
        }
    }
}
