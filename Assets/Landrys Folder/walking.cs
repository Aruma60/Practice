using UnityEngine;
using UnityEngine.InputSystem;

public class TopDownPlayerController : MonoBehaviour
{
    void Start()
    {
    PickupKey.didBluePickup = false;
    }
    
    public float moveSpeed = 10.0f;
   
    [SerializeField] InputActionReference playerMove;

    // Update is called once per frame
    void Update()
    {
        // get horizontal and vertical input
        transform.Translate(playerMove.action.ReadValue<Vector2>() * moveSpeed * Time.deltaTime);
    }
}