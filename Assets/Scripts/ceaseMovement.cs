using UnityEngine;

public class ceaseMovement : MonoBehaviour
{
    public void stopMoving(GameObject item)
    {
        item.GetComponent<Rigidbody>().linearVelocity = Vector3.zero;
    }
}
