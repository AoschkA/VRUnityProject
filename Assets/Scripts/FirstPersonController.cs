using UnityEngine;
using System.Collections;

public class FirstPersonController : MonoBehaviour {
    public float movementSpeed = 10.0F;

	// Use this for initialization
	void Start () {
        Cursor.lockState = CursorLockMode.Locked;
	}
	
	// Update is called once per frame
	void Update () {
        float translation = Input.GetAxis("Vertical") * movementSpeed;
        float straffe = Input.GetAxis("Horizontal") * movementSpeed;
        translation *= Time.deltaTime;
        straffe *= Time.deltaTime;

        transform.Translate(straffe, 0, translation);

        if (Input.GetKeyDown("escape"))
            Cursor.lockState = CursorLockMode.None;


	}
}
