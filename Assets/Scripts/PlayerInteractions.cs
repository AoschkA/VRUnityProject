using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerInteractions : MonoBehaviour {

    public float talkInteractionDistance = 5.0f;
    public float waveInteractionDistance = 10.0f;
    public Text interactionText;

    void Update () {
        // Checks if any NPC is interactable 
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        RaycastHit hit;
        bool talkInteractionRaycastResult = Physics.Raycast(transform.position, fwd, out hit, talkInteractionDistance) 
            && hit.transform.gameObject.tag == "NPC";
        bool waveInteractionRaycastResult = Physics.Raycast(transform.position, fwd, out hit, waveInteractionDistance)
            && hit.transform.gameObject.tag == "NPC";
        // UI update
        interactionText.enabled = talkInteractionRaycastResult;
        // Ready or unready for user input
        FirstPersonController.talkInputReady = talkInteractionRaycastResult;

        if (waveInteractionRaycastResult && hit.transform.gameObject.tag == "NPC") {
            hit.transform.SendMessage("PlayerLooking");
        }

    }
}
