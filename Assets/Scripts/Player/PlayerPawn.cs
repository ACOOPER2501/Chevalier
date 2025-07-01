using UnityEngine;
using System.Collections.Generic; // Importing necessary namespaces for collections
using System.Collections; // Importing necessary namespaces for collections
using UnityEngine.InputSystem; // Importing Unity's Input System for handling player input

//Note: The RequireComponent attribute is used to ensure that the GameObject this script is attached to has a Rigidbody2D component.
//This is important for physics interactions in Unity, as it allows the player to move and interact with the game world using physics-based movement.
[RequireComponent(typeof(Rigidbody2D))] // Ensures that the GameObject has a Rigidbody2D component attached

public class PlayerPawn : MonoBehaviour
{

    // This class handles the player's movement and actions in the game
    public float moveSpeed = 5f; // Speed at which the player moves

    public Vector2 playerMovement; // Stores the player's movement input

    private Rigidbody2D rb; // Reference to the player's Rigidbody2D component for physics interactions

    public Transform spriteTransform; // Reference to the player's sprite transform for flipping the sprite based on movement direction


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>(); // Get the Rigidbody2D component attached to the player GameObject

        if (rb == null) // Check if the Rigidbody2D component is not found
        {
            Debug.LogError("Rigidbody2D component not found on PlayerController GameObject."); // Log an error if Rigidbody2D is not found
        }
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        // This method is called at a fixed interval, typically used for physics updates
        //Note: velocity is outdated and was prompted to use linearVelocity instead.
        rb.linearVelocity = new Vector2(playerMovement.x * moveSpeed, rb.linearVelocity.y);
    }

    // Called by PlayerController to update movement input
    public void SetMovementInput(Vector2 input)
    {
        playerMovement = input;
    }

    public void FlipSprite(bool _isFacingRight)
    {
        if (spriteTransform == null)
        {
            Debug.LogWarning("spriteTransform not assigned.");
            return;
        }

        Vector3 scale = spriteTransform.localScale;
        scale.x = Mathf.Abs(scale.x) * (_isFacingRight ? 1 : -1);
        spriteTransform.localScale = scale;
    }
}
