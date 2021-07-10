using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    static int score;
    // Static variable is shared between all instances of the script, can access using
    // GameManager.score in any other class

    public static void AddScore(int amount) {
        if (amount < 0 && score > 0) {
            score+=amount;
            Debug.Log("Didn't hit a mole!");
            UIManager.instance.UpdateUI();
        }
        else if (amount > 0) {
            score+=amount;
            UIManager.instance.UpdateUI();
        }
    }

    public static int ReadScore() {
        return score;
    }
}
