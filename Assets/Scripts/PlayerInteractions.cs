using UnityEngine;
using System.Collections;

public class PlayerInteractions : MonoBehaviour {

    public float interactionDistance = 5.0f;

    void Update () {
        // Checks if any NPC is interactable 
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        RaycastHit hit;
        if (Physics.Raycast(transform.position, fwd, out hit, interactionDistance) && hit.transform.gameObject.tag == "NPC") {
            hit.transform.SendMessage("PlayerLooking");


        }
    }
}
