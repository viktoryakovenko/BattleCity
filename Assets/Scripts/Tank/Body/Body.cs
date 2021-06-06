using UnityEngine;

public class Body: MonoBehaviour, IMove
{
    public int defense; 
    public float speed;
    public Rigidbody2D rigidBody;

    private Vector2 movement;

    public void Move(float x, float y)
    {
        movement.x = x;
        movement.y = y;

        rigidBody.MovePosition(rigidBody.position + movement * speed * Time.fixedDeltaTime);
    }
}