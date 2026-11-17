using UnityEngine;

public class BlueDisappear : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (bluePickup.didBluePickup)
        {
            Destroy(gameObject);
        } 
    }
}
