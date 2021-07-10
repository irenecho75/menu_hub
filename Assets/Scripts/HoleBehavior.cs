using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleBehavior : MonoBehaviour
{
    public GameObject[] moles;
    // Start is called before the first frame update

    public bool hasMole;

    void Start()
    {
        if (!hasMole) {
            Invoke("Spawn", Random.Range(0f, 7f));
        }
    }

    // Update is called once per frame
    void Spawn() {

        if (!hasMole) {
            int num = Random.Range(0, moles.Length); // returns an int in the range 0 - length of array (inclusive)

            GameObject mole = Instantiate(moles[num], transform.position, Quaternion.identity) as GameObject;
            // Instantiate returns an object, so we typecast as GameObject
            // transform.position (Vec3) will be taken from the hole where the script is sitting on
            // Quaternions are used to represent rotations, and identity means no rotation

            mole.GetComponent<MoleBehavior>().myParent = this.gameObject;
            // Wherever this hole sits on, gets set to be the mole's myParent

            mole.transform.parent = gameObject.transform;
            hasMole = true;

        }
        Invoke("Spawn", Random.Range(0f, 7f));
        // Attemps to instantiate another mole GameObject after 3 - 7 seconds
    }
}
