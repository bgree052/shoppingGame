using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class happyness : MonoBehaviour {

	public int happyScore;
	// Use this for initialization
	void Start () {
		StartCoroutine("HappyDown");
	}
	
	// Update is called once per frame
	void Update () {
	}

	IEnumerator HappyDown() {
		while (happyScore > 0) {
			happyScore = happyScore - 1;
			yield return new WaitForSeconds(0.1f);
		}
	}
}
