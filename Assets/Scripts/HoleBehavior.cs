using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleBehavior : MonoBehaviour
{
    public GameObject[] moles;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Spawn", Random.Range(3f, 7f));
    }

    // Update is called once per frame
    void Spawn() {
        int num = Random.Range(0, moles.Length); // returns an int in the range 0 - length of array (inclusive)

        GameObject mole = Instantiate(moles[num], transform.position, Quaternion.identity) as GameObject;
        // Instantiate returns an object, so we typecast as GameObject
        // transform.position (Vec3) will be taken from the hole where the script is sitting on
        // Quaternions are used to represent rotations, and identity means no rotation


        Invoke("Spawn", Random.Range(3f, 7f));
        // Instantiates another mole GameObject after 3 - 7 seconds
    }
}
