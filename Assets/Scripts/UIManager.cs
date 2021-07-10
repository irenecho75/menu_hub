using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;
    // Create one single static instance of an entire class

    public Text scoreText;
    // Wouldn't be able to edit text box in the hierarchy if this was static (can't be instantiated in scene)

    // Singleton(?)
    void Awake() {

        if (instance != null) {
            GameObject.Destroy(instance);
        }
        instance = this;
        UpdateUI();
    }
    
    public void UpdateUI() {
        scoreText.text = "Score: " + GameManager.ReadScore();
        // Can call since ReadScore is static function
    }
}
