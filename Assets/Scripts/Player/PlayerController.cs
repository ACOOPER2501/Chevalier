using UnityEngine;
using System.Collections.Generic; // Importing necessary namespaces for collections
using System.Collections; // Importing necessary namespaces for collections
using UnityEngine.InputSystem; // Importing Unity's Input System for handling player input

//Note: The RequireComponent attribute is used to ensure that the GameObject this script is attached to has a Rigidbody2D component.
//This is important for physics interactions in Unity, as it allows the player to move and interact with the game world using physics-based movement.
[RequireComponent(typeof(Rigidbody2D))] // Ensures that the GameObject has a Rigidbody2D component attached

public class PlayerController : MonoBehaviour
{

    public PlayerPawn playerPawn; // Reference to the PlayerPawn script, which handles the player's movement and actions

    //Note: The [SerializeField] attribute allows this field to be set in the Unity Inspector while keeping it private.
    [SerializeField]
    private bool _isMoving = false; // Private field to track if the player is currently moving

    //Note: This was created by using the shortcut CTRL + .  on "IsMoving" to generate the property signature.
    public bool IsMoving // Property to check if the player is currently moving
    {
        get // Getter to access the private field _isMoving
        {
            return _isMoving; // Returns the current value of _isMoving
        }
        private set // Setter to update the private field _isMoving
        {
            _isMoving = value; // Sets the value of _isMoving to the provided value
            animator.SetBool("isMoving", value); // Updates the Animator component to reflect the movement state
        }
    }

    [SerializeField] // Allows this field to be set in the Unity Inspector
    private Rigidbody2D rb; // Reference to the player's Rigidbody2D component for physics interactions

    [SerializeField] // Allows this field to be set in the Unity Inspector
    private Animator animator; // Reference to the Animator component for controlling animations

    private void Awake()
    {
      
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   

    // This method is called when the player presses the movement keys (WASD or arrow keys)
    // It reads the input from the Input System and updates the playerMovement vector accordingly
    //Note: This is done in Unity's new Input System, which allows for more flexible and customizable input handling.
    public void OnMove(InputAction.CallbackContext context) // Handles player movement input
    {
        Vector2 movement = context.ReadValue<Vector2>(); // Read the player's movement input from the context menu
        playerPawn.SetMovementInput(movement);
        IsMoving = movement != Vector2.zero; // Check if the player is moving by comparing the input vector to zero
        //Note: used the shortcut CTRL + . to generate the method signature

        SetFaceDirection(movement); // Call the method to set the player's facing direction based on the movement input
    }

    private void SetFaceDirection(Vector2 movement) // Sets the player's facing direction based on the movement input
    {
        // This method checks the movement input and updates the player's facing direction accordingly
        //Note: The && operator is a logical AND operator that checks if both conditions are true.
        //So, We are setting the player's facing direction based on the movement input.
        if (movement.x > 0 && !IsFacingRight) // If statement to check if the player is facing right 
        {
            IsFacingRight = true; // Set the IsFacingRight property to true
        }
        else if (movement.x < 0 && IsFacingRight) // If the player is moving to the left
        {
            IsFacingRight = false; // Set the IsFacingRight property to false
        }
    }

    // This property indicates whether the player is facing right or not
    public bool _isFacingRight = true;

    //Note: The IsFacingRight property is used to determine the player's facing direction.
    public bool IsFacingRight // Property to check if the player is facing right
    {
        get // Getter to access the private field _isFacingRight
        {
            return _isFacingRight; // Returns the current value of _isFacingRight

        }
        private set // Setter to update the private field _isFacingRight
        {
            if(_isFacingRight != value)
            {
                //Flip the local scale of the player to face the correct direction
                transform.localScale *= new Vector2(-1, 1); // Flip the player sprite horizontally
            }

            _isFacingRight = value; // Sets the value of _isFacingRight to the provided value
        }
    }

    public void OnAttack()
    {

    }
}
