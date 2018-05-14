using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	public int min = 1;
	public int max = 1000;
	public int guess = 500;

	// Use this for initialization
	void Start () {
		max++;
		guess = (max + min) / 2;
		print("Welcome to Number Wizard");
		print("Pick a number in your head, but don't tell me!");
		
		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);

		print("Is the number higher or lower than "+guess+"?");
		print ("Up = higher, Down = lower, return = equal");
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			min = guess;
			guess = (max + min) / 2;
			print("Higher or lower than " + guess + "?");
		} else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			max = guess;
			guess = (max + min) / 2;
			print("Higher or lower than " + guess + "?");
		} else if (Input.GetKeyDown(KeyCode.Return)) {
			print("I won!");
		}
	}
}
