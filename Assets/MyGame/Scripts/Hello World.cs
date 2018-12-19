using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log("Hello World");
		
		//Aufruf Methode
		float number = getRandom();
		Debug.Log("random number: " + number);
	}
	
	//deklaration Methode
	float getRandom (){
		return UnityEngine.Random.Range(0f,10f);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
