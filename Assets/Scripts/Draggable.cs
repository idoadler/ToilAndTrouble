using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour {

	float x;
	float y;
	Vector3 startPos;
	bool free = true;

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
		if (free)
			//GetComponent<Rigidbody2D>().MovePosition(Camera.main.ScreenToWorldPoint(Input.mousePosition));
			transform.position = Camera.main.ScreenToWorldPoint(new Vector3(x,y,10.0f));
	}

	void OnTriggerEnter2D(Collider2D other) {
		free = false;
		transform.position = startPos;

		//if (coll.gameObject.tag == "Enemy")
		//coll.gameObject.SendMessage("ApplyDamage", 10);
		//Destroy(this.gameObject);
	}

}
