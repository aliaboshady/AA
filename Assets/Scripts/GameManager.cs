using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	bool gameHasEnded = false;
	public Rotator rotator;
	public Spawner spawner;
	public Animator animator;

	public void EndGame () {
		if (gameHasEnded) {
			return;
		}
		gameHasEnded = true;
		rotator.enabled = false;
		spawner.enabled = false;

		animator.SetTrigger ("End Game");
	}

	public void Restart(){
		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
	}
}
