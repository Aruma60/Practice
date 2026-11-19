using UnityEngine;

public class redPickup : MonoBehaviour
{
    public static bool didRedPickup = false;
    void Start()
    {

    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && !didRedPickup)
        {
            redPickup.didRedPickup = true;
            Destroy(gameObject);
        }
    }
}