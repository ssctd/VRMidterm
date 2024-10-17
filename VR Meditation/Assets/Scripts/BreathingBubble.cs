using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BreathingBubble : MonoBehaviour
{
    //public MeshRenderer Renderer;
    bool extend;
    public float radius;
    public GameObject InhaleText, ExhaleText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Breathing extending or not
        if(extend)
        {
            transform.localScale = transform.localScale * 1.002f;
            InhaleText.SetActive(true);
            ExhaleText.SetActive(false);
            if(transform.localScale.x > 425f)
            {
                extend = false;
            }
        }
        else
        {
            transform.localScale = transform.localScale * 0.998f;
            InhaleText.SetActive(false);
            ExhaleText.SetActive(true);
            if(transform.localScale.x < 250f)
            {
                extend = true;
            }
        }
    }
}
