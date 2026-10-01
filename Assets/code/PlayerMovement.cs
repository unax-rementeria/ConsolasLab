using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private float movement;
    private 
    public float speed = 5f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    private void OnMove(InputValue movementValue)
    {
        Vector2 movementVector = movementValue.Get<Vector2>();
        movement = movementVector.x;
    }
    void FixedUpdate()
    {
        Vector3 movement = new Vector3(movement, 0.0f, 0.0f);
        rb.AddForce(movement * speed);
    }

}