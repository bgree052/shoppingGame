using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class faceSwap : MonoBehaviour {

	public happyness yay;
	public GameObject face;
	Image faces;
	public Sprite[] mySprites;
	// Use this for initialization
	void Start () {
		faces = face.GetComponent<Image>();
	}
	
	// Update is called once per frame
	void Update () {
		if (yay.happyScore > 80) {
			faces.sprite = mySprites[3];
		} else if (yay.happyScore > 60) {
			faces.sprite = mySprites[0];
		} else if (yay.happyScore > 40) {
			faces.sprite = mySprites[2];
		} else if (yay.happyScore > 20) {
			faces.sprite = mySprites[1];
		} else if (yay.happyScore > 0) {
			faces.sprite = mySprites[4];
		} 
	}
}
