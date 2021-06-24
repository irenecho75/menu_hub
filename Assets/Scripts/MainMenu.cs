using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void LoadDemo1() {
        SceneManager.LoadScene("Demo1");
    }
    public void LoadDemo2() {
        SceneManager.LoadScene("Demo2");
    }
    public void Quit() {
        Debug.Log("Quit");
        Application.Quit();
    }
}
