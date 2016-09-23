using UnityEngine;
using System.Collections;

public class constantRotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}

void Update ()
	{
		transform.Rotate (0,10,0*Time.deltaTime); //rotates 50 degrees per second around z axis
	}
}
