using UnityEngine;

public class purplePickup : MonoBehaviour
{
    public static bool didPurplePickup = false;
    void Start()
    {

    }
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && !didPurplePickup)
        {
            purplePickup.didPurplePickup = true;
            Destroy(gameObject);
        }
    }
}