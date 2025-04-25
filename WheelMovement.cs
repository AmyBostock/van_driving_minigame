using UnityEngine;

public class WheelMovement : MonoBehaviour
{
    private float rotationSpeed = 200f;
    private float forwardInput;
    private float horizontalInput;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Rotate(Vector3.right * Time.deltaTime * rotationSpeed * forwardInput);
       
    }
}
