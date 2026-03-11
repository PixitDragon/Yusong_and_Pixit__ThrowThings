using UnityEngine;

public class colliderHit : MonoBehaviour
{

    public string diskNumber;
    public pointsManagement pointsAdd;
    Vector3 goalSpawnRegion;
    public colorChangeToRGB colChng;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(diskNumber)){
            Debug.Log("Disk entered goal!");
            //add point
            pointsAdd.addPoint();
            //reset disk

            //reset goal
            resetGoalLocation();
            colChng.runColorChange(UnityEngine.Random.Range(0, 256), UnityEngine.Random.Range(0, 256), UnityEngine.Random.Range(0, 256)); ;

        }
    }
    public void resetGoalLocation() {
        goalSpawnRegion = new Vector3(Random.Range(4,-4), Random.Range(-1, 5), Random.Range(5, 8));
        this.transform.position= goalSpawnRegion;
    }

}
