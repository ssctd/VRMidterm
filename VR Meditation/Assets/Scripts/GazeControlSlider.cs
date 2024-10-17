using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GazeControlSlider : MonoBehaviour
{
    public Image fillImage; // This Image is to represent the filled part of the slider
    public float loadingTime = 3f; // Total time for loading
    private float currentTime = 0f;
    private bool isGazing = false;

    void Update()
    {
        if (isGazing)
        {
            currentTime += Time.deltaTime;

            // Calculate fill amount based on elapsed time
            float fillAmount = currentTime / loadingTime;
            fillImage.fillAmount = Mathf.Clamp01(fillAmount);

            // Check loading is complete or not
            if (currentTime >= loadingTime)
            {
                // Loading complete: reset
                Debug.Log("Loading Complete");
                ResetSlider();
            }
        }
    }

    public void StartGaze()
    {
        isGazing = true;
        currentTime = 0f; // Reset timer
    }

    public void EndGaze()
    {
        isGazing = false; // end loading, if gaze is not maintained
    }

    public void ResetSlider()
    {
        fillImage.fillAmount = 0f;
        currentTime = 0f;
    }
}
