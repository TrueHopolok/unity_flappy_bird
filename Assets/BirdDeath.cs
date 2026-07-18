using UnityEngine;

public class BirdDeath : MonoBehaviour
{
    [SerializeField] float deathVelocity = 20f;
    [SerializeField] float extraGravityForce = -80f;
    BirdInput birdInput;
    Rigidbody2D rigidBody;
    Collider2D birdCollider;

    void Awake()
    {
        birdInput = GetComponent<BirdInput>();
        rigidBody = GetComponent<Rigidbody2D>();
        birdCollider = GetComponent<CircleCollider2D>();
    }

    public void Die()
    {
        Debug.Log("Bird died");

        // This disables all Update calls
        // This includes: Update, FixedUpdate, LateUpdate, OnGUI
        birdInput.enabled = false;                  // disable input
        birdCollider.enabled = false;               // disable futher collission
        enabled = true;                             // enable this script FixedUpdate
        rigidBody.linearVelocityY = deathVelocity;  // set initial velocity
    }

    // Only called if object is enabled
    // Change this script default state to disabled
    void FixedUpdate()
    {
        // Add extra gravity so on death bird would fall faster
        rigidBody.AddForceY(extraGravityForce);
    }
}
