using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoleBehavior : MonoBehaviour
{
    Collider col;

    public int score = 1;

    [HideInInspector]public GameObject myParent;
    // Like storing a reference to the hole GameObject associated with the current mole GameObject

    [HideInInspector]public Animator anim;
    // Don't want to see animator component in the inspector

    void Start() {

        anim = GetComponent<Animator>();
        // Returns the component of type Animator if GameObject has one attached

        col = GetComponent<Collider>();
        // Returns the component of type Collider if the GameObject has one attached, null if it doesn't
        // Don't need to specify exact collider we're usimg

        col.enabled = false;
        // At start of program, want it to be not disabled (not updated)
    }
    public void DestroyObj() {
        myParent.GetComponent<HoleBehavior>().hasMole = false;
        Destroy(gameObject);
    } 
    public void SwitchCollider(int num) {
        col.enabled = (num == 0) ? false : true;
        // If num is not 0, then enable Collider col
    }

    public void GotHit() {
        // add points here

        int num = Random.Range(1, 4);
        // Random number from 1-3

        string soundName = "MoleHit" + num;
        FindObjectOfType<AudioManager>().Play(soundName);

        GameManager.AddScore(score);
    }
}
