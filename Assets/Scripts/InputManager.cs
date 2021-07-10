using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        // Left mouse button is 0, right button is 1
        if (Input.GetMouseButtonDown(0)) {

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            // Returns a ray going from the camera to the mouse's position

            RaycastHit hit;
            // Structure used to get information back from a raycast, returned
            // when ray hits an objects during a raycast

            if (Physics.Raycast(ray, out hit)) {
            // Returns true if the ray intersects with a collider, else false
            // "out" passes hit by reference

                if (hit.collider.tag == "Mole") {

                    MoleBehavior mole = hit.collider.gameObject.GetComponent<MoleBehavior>();
                    // Want to get the component MoleBehavior from the object that was hit
                    mole.SwitchCollider(0);
                    // Turns the collider off

                    mole.anim.SetTrigger("hit");
                    // Triggers the GetHit animation
                    
                    Debug.Log(hit.collider.gameObject + " got hit!");
                }
                else {
                    GameManager.AddScore(-1);
                }
            }
        }
    }
}
