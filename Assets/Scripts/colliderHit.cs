using UnityEngine;

public class colliderHit : MonoBehaviour
{

    public string diskNumber;
    public pointsManagement pointsAdd;
    public colorChangeToRGB colChng;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag(diskNumber)){
            Debug.Log("Disk entered goal!");
            //add point
            pointsAdd.addPoint();
            //reset disk
            colChng.runColorChange(UnityEngine.Random.Range(0, 256), UnityEngine.Random.Range(0, 256), UnityEngine.Random.Range(0, 256)); ;

        }
    }

}
