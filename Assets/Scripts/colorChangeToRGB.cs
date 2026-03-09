using UnityEngine;

public class colorChangeToRGB : MonoBehaviour
{
    public Material toChange;
    public Color newColor;
    public void runColorChange(float red, float green, float blue) {
        toChange.color = new Color(red/256,green/256,blue/256);
    }
}

