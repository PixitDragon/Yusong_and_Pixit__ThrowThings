using UnityEngine;

public class teleportTo : MonoBehaviour
{
    [Header("XYZ of where to teleport the object to")]
    public Vector3 positionToTpTo;

    public void teleport(GameObject item)
    {
        item.transform.position = positionToTpTo;
        item.transform.position = new Vector3(Random.Range(-1f, -0.4f), 5, Random.Range(0f, -0.6f));
    }
}
//0.2609 0.0349
//0.035