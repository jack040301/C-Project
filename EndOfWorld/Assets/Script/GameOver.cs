using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject gameoverPanel;
	// Update is called once per frame
	void Update () {
		if (GameObject.FindGameObjectWithTag ("Player") == null) {
			gameoverPanel.SetActive (true);
		}
	}

	public void Restart(){
		SceneManager.LoadScene(SceneManager.GetActiveScene ().name);
	}
}
