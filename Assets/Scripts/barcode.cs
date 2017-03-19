using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barcode : MonoBehaviour {
	public GameObject scanner;

    int scanned = 0;
	// Use this for initialization
	void Start () {
		scanner = GameObject.Find("Scaner");
	}
	
	// Update is called once per frame
	void Update () {
		// Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;

		Vector3 forward = transform.TransformDirection(-Vector3.up);

        Debug.DrawRay(transform.position, forward, Color.green);
        RaycastHit hit;
        int layerMask = 1 << 9;
        if (Physics.Raycast(transform.position, forward, out hit, 1, layerMask) ) {
            if(hit.collider.name == "Scaner" && scanned == 0) {
                scanner.SendMessage("Scanned");
                scanned++;
            }
        } else {
            scanned = 0;
        }
	}
}
