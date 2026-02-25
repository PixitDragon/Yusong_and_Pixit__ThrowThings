using UnityEngine;

public class teleportTo : MonoBehaviour
{
    [Header("XYZ of where to teleport the object to")]
    public Vector3 positionToTpTo;

    public void teleport(GameObject item)
    {
        item.transform.position = positionToTpTo;
    }
}
