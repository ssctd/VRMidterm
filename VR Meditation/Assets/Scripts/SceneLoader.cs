using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
   public void LoadSceneNature()
    {
        SceneManager.LoadScene("360VideoNature");
    }

    public void LoadSceneFort()
    {
        SceneManager.LoadScene("360VideoFort");
    }

    public void LoadSceneHome()
    {
        SceneManager.LoadScene("StartScene");
    }
}
