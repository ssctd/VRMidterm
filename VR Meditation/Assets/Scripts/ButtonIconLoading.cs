using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonIconLoading : MonoBehaviour
{
    public Image loadingIcon; // Reference to the loading icon Image.
    public float selectionTime = 4f;
    private float countdown;
    private bool isLookingAtButton;

    void Update()
    {
        if (isLookingAtButton)
        {
            countdown -= Time.deltaTime;

            //update the fill amount of the loading icon
            loadingIcon.fillAmount = Mathf.Clamp01(1 - (countdown / selectionTime));

            if (countdown <= 0)
            {
                ExecuteButtonAction();
            }
        }
    }

    public void StartLookingAtButton()
    {
        countdown = selectionTime;
        loadingIcon.gameObject.SetActive(true); // Show Loading icon
        isLookingAtButton = true;
    }

    public void StopLookingAtbutton()
    {
        loadingIcon.gameObject.SetActive(false); // Hide loading icon
        isLookingAtButton= false;
    }

    public void ExecuteButtonAction()
    {
        //Preform the button action here
        Debug.Log("Button executed!");
        StopLookingAtbutton();
    }

    //Call these methods from the Raycast logic when the plauer looks at the button
    public void OnGazeEnter()
    {
        Debug.Log("Gaze entered");
        StartLookingAtButton();
    }

    public void OnGazeExit()
    {
        Debug.Log("Gaze exited");
        StopLookingAtbutton();
    }
}
