using UnityEngine;

public class colliderHit : MonoBehaviour
{
    public pointsManagement pointsAdd;
    Vector3 goalSpawnRegion;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Disk1")){
            Debug.Log("Disk entered goal!");
            //add point
            pointsAdd.addPoint();
            //reset disk

            //reset goal
            resetGoalLocation();
        }
    }
    public void resetGoalLocation() {
        goalSpawnRegion = new Vector3(Random.Range(4,-4), Random.Range(1, 2), Random.Range(5, 7));
        this.transform.position= goalSpawnRegion;
    }

}
