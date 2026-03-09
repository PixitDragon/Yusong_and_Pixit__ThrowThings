using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class pointsManagement : MonoBehaviour
{
    public int points;
    public TextMeshProUGUI pointsText;

    private void Start()
    {
        points=0;
        UpdatePointsText();
    }

    public void addPoint()
    {
        points += 1;
        UpdatePointsText();
    }

    private void UpdatePointsText()
    {
        pointsText.text = "Points: " + points;
    }
}
