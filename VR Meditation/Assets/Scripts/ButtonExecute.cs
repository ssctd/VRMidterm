using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonExecute : MonoBehaviour
{
    //public Button startButton, stopButton;
    Button hitButton, currentButton;

    private float timer;
    private float selectionTime = 3f;

    //private float currentTime = 0f;
    public Image loadingImage;

    //public GazeControlSlider MountainSlider, CastleSlider;

    // Start is called before the first frame update
    void Start()
    {
        timer = selectionTime;
    }

    // Update is called once per frame
    void Update()
    {
        Transform camera = Camera.main.transform;
        Ray ray = new Ray(camera.position, camera.rotation * Vector3.forward);
        Debug.DrawRay(camera.position, camera.rotation * Vector3.forward * 100, Color.red);
        RaycastHit hit;

        loadingImage.fillAmount = timer/selectionTime;


        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.gameObject.tag == "Button")
            {
                
                if(timer < 0)
                {
                    hitButton = hit.transform.parent.gameObject.GetComponent<Button>();
                    print("name= " + hitButton.name);
                    timer = selectionTime;

                }
                else
                {
                    timer -= Time.deltaTime;
                    print("Time left: " + timer);
                }
                



                //New code Below...
                /*
                hitButton = hit.transform.parent.gameObject.GetComponent<Button>();
                print("name= " + hitButton.name);

                // Check if we are looking at a new button
                if (currentButton != hitButton)
                {
                    // Unhighlight the previous button
                    if (currentButton != null)
                    {
                        currentButton.OnPointerExit(new PointerEventData(EventSystem.current));
                    }

                    currentButton = hitButton;
                    if (currentButton != null)
                    {
                        currentButton.OnPointerEnter(new PointerEventData(EventSystem.current));

                        currentTime = 0f; // Reset timer
                        MountainSlider.StartGaze(); // Start the gaze slider
                        CastleSlider.StartGaze();
                    }
                }

                currentTime += Time.deltaTime;

                if (currentTime >= timer)
                {
                    currentButton.onClick.Invoke(); // Invoke button action
                    currentTime = 0f; // Reset timer
                    MountainSlider.ResetSlider(); // Reset the slider when button is clicked
                    CastleSlider.ResetSlider();
                }
                */
                //New code above...




            }
            else
            {

                timer = selectionTime;
                hitButton = null;
                Debug.Log("Selection Time: " + selectionTime);

                //ResetButton(); //<--- New Code
            }


            
            if (currentButton != hitButton)
            {
                //unhighlight
                if (currentButton != null)
                {
                    currentButton.OnPointerExit(new PointerEventData(EventSystem.current));
                }
                //make changes
                currentButton = hitButton;
                if (currentButton != null)
                {
                    currentButton.onClick.Invoke();
                    currentButton.OnPointerEnter(new PointerEventData(EventSystem.current));
                }
            }           
        }
        //New Code Below....
        /*
        else
        {
            ResetButton();
        }
        //New Code Above...
        */
    }


    /*
    private void ResetButton()
    {
        //Resets the button
        if(currentButton != null)
        {
            currentButton.OnPointerExit(new PointerEventData(EventSystem.current));
            currentButton = null;
            MountainSlider.EndGaze();
            MountainSlider.ResetSlider();
            CastleSlider.EndGaze();
            CastleSlider.ResetSlider();
        }
    }
    */
}
