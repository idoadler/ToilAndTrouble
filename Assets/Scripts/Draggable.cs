using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour {

	float x;
	float y;
	Vector3 startPos;

	// Use this for initialization
	void Start () {
		startPos = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		x = Input.mousePosition.x;
		y = Input.mousePosition.y;
	}
		
	void OnMouseDrag(){
		transform.position = Camera.main.ScreenToWorldPoint(new Vector3(x,y,10.0f));
	}

	void OnTriggerEnter2D(Collider2D other) {
		transform.rotation = new Quaternion(0,0,.5f,1);
	}

	void OnTriggerExit2D(Collider2D other) {
		transform.rotation = Quaternion.identity;
	}

	void OnMouseUp() {
		transform.rotation = Quaternion.identity;
		transform.position = startPos;
	}
}
