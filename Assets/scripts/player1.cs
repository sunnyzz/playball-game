using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1 : MonoBehaviour {
	public float playerspeed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)) {  
			print ("w");  
			transform.Translate (Vector3.up * Time.deltaTime * playerspeed);  
		}  

		//向下运动——S  
		if (Input.GetKey (KeyCode.S)) {  
			print ("s");  
			transform.Translate (Vector3.down * Time.deltaTime * playerspeed);  
		}  

		//向左运动——A  
		if (Input.GetKey (KeyCode.A)) {  
			print ("a");  
			transform.Translate (Vector3.left * Time.deltaTime * playerspeed);  
		}  

		//向右运动——D  
		if (Input.GetKey (KeyCode.D)) {  
			print ("d");  
			transform.Translate (Vector3.right * Time.deltaTime * playerspeed);  
		}  
		if(Input.GetMouseButton(0)){
			transform.Rotate(Vector3.down* playerspeed,Space.World);
		}
		//鼠标判断
		if(Input.GetMouseButton(1)){
			transform.Rotate(Vector3.up* playerspeed,Space.World);
		}

	}
}
