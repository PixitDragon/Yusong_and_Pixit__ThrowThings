using UnityEngine;

public class colorChangeToRGB : MonoBehaviour
{
    public Material toChange;
    public Color newColor;
    public void runColorChange(GameObject item, int red, int green, int blue) {
        toChange.color = UnityEngine.Random.ColorHSV();
    }
}

