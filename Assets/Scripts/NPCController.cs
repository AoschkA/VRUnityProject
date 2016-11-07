using UnityEngine;
using System.Collections;

public class NPCController : MonoBehaviour {
    Animator anim;

    void Start() {
        anim = GetComponent<Animator>();
    }

    void PlayerLooking() {
        anim.SetTrigger("Greetings");
    }
}
