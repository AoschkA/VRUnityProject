using UnityEngine;
using System.Collections;

public class PlayerInteractions : MonoBehaviour {

    public float interactionDistance = 5.0f;

    void Update () {

        // Checks if any NPC is interactable 
        if (Physics.Raycast(this.transform.position, -Vector3.up, interactionDistance)) {
            print("interaction");
        } else {
            print("no interaction");
        }
	}
}
