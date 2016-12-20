using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2 : MonoBehaviour {
	private bool isMouseDown = false;  
	private Vector3 lastMousePosition = Vector3.zero;  



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0))  
		{  
			isMouseDown = true;
			Debug.Log("Pressed left click.");
		}  
		if (Input.GetMouseButtonUp(0))  
		{  
			isMouseDown = false; 
			lastMousePosition = Vector3.zero;
			Debug.Log("Pressed ");
		}  
		if (isMouseDown)  
		{  
			if (lastMousePosition != Vector3.zero)  
			{  
				Vector3 offset = Camera.main.ScreenToWorldPoint(Input.mousePosition) - lastMousePosition;  
				this.transform.position += offset;  
			}  
			lastMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);  

		}  

	}

}
