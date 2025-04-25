using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Private - can only be used inside this class
    public GameObject player;
    private Vector3 offset = new Vector3(0, 6, -9);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    // LateUpdate updates after the update method happens (in Player Controller). So camera will move after the vehicle has moved
    void LateUpdate()
    {
        // Offset the camera behind the player by adding to the player's position
        transform.position = player.transform.position + offset;
    }
}
