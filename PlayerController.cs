using UnityEngine;
using UnityEngine.UIElements;

public class PlayerController : MonoBehaviour
{
    // Public - can be shared and edited in Unity
    // float - used when a decimal point is being used
    // variables - lower case
    
    // Private Variables
    private float speed = 10.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // horizontalInput - gets the float "horizontalInput"
        // "=" - set
        // Input - Input Manager in unity
        // GetAxis - gets the axis thats horizontal
        // "Horizontal" inside Unity Input Manager the horizontal axis is called Horizontal. The double "" will get the string name
        // then multiply the transform translate equation by the horizontal input

        // This is where we get player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // Move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // Turn the vehicle
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);
        

    }
}
