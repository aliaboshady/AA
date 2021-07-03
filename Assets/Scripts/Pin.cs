using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour {
	public float speed = 20f;
	public Rigidbody2D rb;
	bool isPinned = false;

	void Update () {
		if (!isPinned) {
			rb.MovePosition (rb.position + Vector2.up * speed * Time.deltaTime);
		}
	}

	void OnTriggerEnter2D(Collider2D col){
		
		if (col.CompareTag ("Rotator")) {
			transform.SetParent (col.transform);
			Score.PinCount++;
			isPinned = true;
		}

		if (col.CompareTag ("Pin")) {
			FindObjectOfType<GameManager>().EndGame();
		}
	}
}