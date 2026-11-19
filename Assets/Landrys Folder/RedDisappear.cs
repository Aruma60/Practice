using UnityEngine;

public class RedDisappear : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (redPickup.didRedPickup)
        {
            Destroy(gameObject);
        } 
    }
}
