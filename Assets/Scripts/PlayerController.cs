using System.Collections;
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
    [SerializeField] 
    private ParticleSystem landExplosion; 

    //Sidequest 2
    private bool superSpeed = false;
    public int superSpeedDuration;


    void Awake()
    {
        // Initialize
        rBody = GetComponent<Rigidbody2D>();
        stats = new PlayerStats(); //moveSpeed is in the 'black box'
    }

    void FixedUpdate()
    {
        Movement();
    }

    //Method Declarations
    void Movement()
    {
        if (superSpeed)
        {
            SuperMovement();
        }
        else
        {
            ApplyMovement();
        }
    }
    
    void ApplyMovement()
    {
      float velocityX = moveInput.x; // Local variable

    rBody.linearVelocity = new Vector2(velocityX, rBody.linearVelocity.y);
    }
    void SuperMovement()
    {
        StartCoroutine(SupermoveSlowdown());
        float velocityX = moveInput.x;
        rBody.linearVelocity = new Vector2(velocityX * 5, rBody.linearVelocity.y);
    }

    IEnumerator SupermoveSlowdown()
    {
        yield return new WaitForSeconds(superSpeedDuration);
        superSpeed = false;
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








    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }
}
