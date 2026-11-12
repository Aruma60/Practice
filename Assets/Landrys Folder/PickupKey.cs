using UnityEngine;

public class PickupKey : MonoBehaviour
{
    public static bool didBluePickup = false;
    void Start()
    {

    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && !didBluePickup)
        {
            PickupKey.didBluePickup = true;
            Destroy(gameObject);
        }
    }
}