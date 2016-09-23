using UnityEngine;
using System.Collections;

public class RandomVector : MonoBehaviour {

	public float speed = 8f; //when you put "public" before something, it shows up in Unity

	float lastTimeWhenIMoved = 0f;
	//declaring variable, will remember when last time it moved was
	Vector3 myDestination; //remember where I want to move, it has to be stored in a variable "Vector3"



	// Update is called once per frame
	void Update () {
//		transform.position = new Vector3 (1f, 15f, 4.20f);
			//stores where something is, so above is 1 on the x-axis, 15 on the y-axis, 420 on the z-axis
		//set a new place where I want to go
		if (Time.time > lastTimeWhenIMoved + 0.5f) {
			myDestination = new Vector3 ( Random.Range(-20f,20f), 1.07f, Random.Range(-20f,20f));
			lastTimeWhenIMoved = Time.time; //update last time when I moved
			//when enough time has passed, it will pick a new spot; after one second
		}	//you can add rotate to this, you can make a clock if you wanted to
		//okay let's actually move now
		transform.position = Vector3.MoveTowards( transform.position,
												  myDestination,
												  Time.deltaTime * speed
												);

		print("It works");//just to see when it works
	}//end of Update()
}
