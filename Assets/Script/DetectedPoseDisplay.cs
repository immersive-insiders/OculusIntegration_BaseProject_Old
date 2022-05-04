using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DetectedPoseDisplay : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textDisplay;

    public void DisplayPose(string poseName)
    {
        textDisplay.text = poseName;
    }

}
