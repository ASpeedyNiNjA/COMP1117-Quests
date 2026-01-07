using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{

    private PlayerStats stats;

    //Field Variables
    private Vector2 moveInput;
  

    //Components
    private Rigidbody2D rBody; //Field Variable


    void Awake()
    {
        // Initialize
        rBody = GetComponent<Rigidbody2D>();
        stats = new PlayerStats();
        int something = stats.MoveSpeed;

    }

    void OnMove(InputValue value)
    {
        moveInput = value.Get<Vector2>();
    }

    void FixedUpdate()
    {
        ApplyMovement();
    }

    void ApplyMovement()
    {
      float velocityX = moveInput.x;

    rBody.linearVelocity = new Vector2(velocityX, rBody.linearVelocity.y);
    }
}
