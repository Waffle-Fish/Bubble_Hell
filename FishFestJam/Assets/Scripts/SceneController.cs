using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    // private void Awake() {
    //     DontDestroyOnLoad(this.gameObject);
    // }

    public void LoadScene(int buildIndex)
    {
        SceneManager.LoadScene(buildIndex);
    }
    public void Quit() {
        Application.Quit();
    }
}
