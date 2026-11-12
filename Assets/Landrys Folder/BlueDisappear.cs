using UnityEngine;

public class BlueDisappear : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (PickupKey.didBluePickup)
        {
            Destroy(gameObject);
        } 
    }
}
