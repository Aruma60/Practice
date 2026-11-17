using UnityEngine;

public class bluePickup : MonoBehaviour
{
    public static bool didBluePickup = false;
    void Start()
    {

    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && !didBluePickup)
        {
            bluePickup.didBluePickup = true;
            Destroy(gameObject);
        }
    }
}