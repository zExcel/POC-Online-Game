using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    void Start ()
    {
        print("test");
    }

    public void PlayGame ()
    {
        string sceneName = "Island";
        
        SceneManager.LoadSceneAsync(sceneName);
    }

}
