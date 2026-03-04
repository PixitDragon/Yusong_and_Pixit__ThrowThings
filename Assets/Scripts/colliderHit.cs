using UnityEngine;

public class colliderHit : MonoBehaviour
{
    public pointsManagement pointsAdd;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Disk1")){
            Debug.Log("Disk entered goal!");
            //add point
            pointsAdd.addPoint();
            //reset disk
        }
    }

}
