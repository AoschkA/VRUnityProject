using UnityEngine;
using System.Collections;

public class NPCController : MonoBehaviour {
    Animator anim;

    void Start() {
        anim = GetComponent<Animator>();
    }

    void PlayerLooking() {
        print("raycast hit");
    }
}
