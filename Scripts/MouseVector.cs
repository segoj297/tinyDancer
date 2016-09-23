using UnityEngine;
using System.Collections;

public class MouseVector : MonoBehaviour {

	//public float mouseX = 0f;
	//public float mouseY = 0f;

	public float mouseX = 0.5f, mouseY = 1.07f;

	// Update is called once per frame
	void Update () {

		//Cursor.visible = false;
		// "mouse deltas"
		//if we don't move the mouse, it's equal to 0
		mouseX = Input.GetAxis ("Mouse X");
		mouseY = Input.GetAxis ("Mouse Y");

		//move object based on current mouseSpeed
		//transform.position = new Vector3 (mouseX, 0f, mouseY);

		//move object, but ON TOP of previous position
		transform.position += new Vector3 (mouseX, 0f, mouseY);
	}
}
