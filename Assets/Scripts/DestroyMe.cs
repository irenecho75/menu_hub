using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMe : MonoBehaviour
{
    Collider col;

    void Start() {
        col = GetComponent<Collider>();
        // Returns the component of type Collider if the GameObject has one attached, null if it doesn't
        // Don't need to specify exact collider we're usimg

        col.enabled = false;
        Debug.Log("why");
        // At start of program, want it to be not disabled (not updated)
    }
    public void DestroyObj() {
        Destroy(gameObject);
    } 
    public void SwitchCollider(int num) {
        col.enabled = (num == 0) ? false : true;
        // If num is not 0, then enable Collider col
    }
}
