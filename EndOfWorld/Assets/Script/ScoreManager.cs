using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoretext;
    private float score;
    void Update()
    {
        if (GameObject.FindGameObjectWithTag ("Player") != null) {
			score += 1 * Time.deltaTime;
            scoretext.text = ((int)score).ToString();
		}
    }
}
