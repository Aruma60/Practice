using UnityEngine;

public class PurpleDisappear : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (purplePickup.didPurplePickup)
        {
            Destroy(gameObject);
        } 
    }
}
