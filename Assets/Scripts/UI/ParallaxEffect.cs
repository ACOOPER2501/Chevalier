using UnityEngine;
using System.Collections.Generic; // Importing necessary namespaces for collections

public class ParallaxEffect : MonoBehaviour
{

    public Camera cam; // Reference to the camera for calculating parallax effect

    public Transform followPawn; // Reference to the pawn (player character) that the camera will follow

    Vector2 startPos; // Starting position of the camera

    public float startingZPos; // Starting Z position of the camera

    Vector2 camMoveSinceStart => (Vector2) cam.transform.position - startPos; // Calculate the camera movement since the start position

    // Calculate the parallax factor based on the distance from the target pawn to the camera and the clipping plane
    private float parallaxFactor => Mathf.Abs(zDistanceFromTarget) / clippingPlane; 

    float zDistanceFromTarget => transform.position.z - followPawn.position.z; // Calculate the distance from the target pawn to the camera

    // Calculate the distance from the subject (pawn) to the camera
    // How this is calculated depends on the camera's perspective and the distance from the subject
    //Note: The ? in C# is a conditional operator that checks if zDistanceFromTarget is greater than 0.
    //Think of it like a shorthand for an if-else statement.
    //The : operator is used to return one of two values based on the condition.
    //So, if zDistanceFromTarget is greater than 0, it returns cam.farClipPlane; otherwise, it returns cam.nearClipPlane.
    //The farClipPlane and nearClipPlane are properties of the Camera class in Unity that define the distances at which objects are rendered.
    float clippingPlane => cam.transform.position.z + (zDistanceFromTarget > 0 ? cam.farClipPlane : cam.nearClipPlane);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        startPos = transform.position; // Store the initial position of the camera

        startingZPos = transform.position.z; // Store the initial Z position of the camera
    }

    // Update is called once per frame
    void Update()
    {
        // Calculate the new position of the camera based on the parallax effect
        Vector2 newPos = startPos + camMoveSinceStart * parallaxFactor;

        transform.position = new Vector3(newPos.x, newPos.y, startingZPos); // Update the camera position based on the calculated parallax effect
    }
}
