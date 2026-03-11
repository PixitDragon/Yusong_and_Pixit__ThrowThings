using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class pointsManagement : MonoBehaviour
{
    public int points;
    public TextMeshProUGUI pointsTextHeadset;
    public TextMeshPro pointsTextScoreboard;

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
        pointsTextHeadset.text = "Points: " + points;
        pointsTextScoreboard.text = "Points: " + points;
    }
}
