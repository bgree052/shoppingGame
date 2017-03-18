using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnProducts : MonoBehaviour {

	public GameObject prod1;
	//public GameObject prod2;

	new Vector3 loc;

	Product[] products;

	// Use this for initialization
	void Start () {
		//products = new ArrayList ();

		GameObject productsObj = GameObject.Find ("productManager");
		products = productsObj.GetComponent<productManagement>().products;
		Debug.Log(products);
		//products = productManagement();
			
		loc = gameObject.transform.position;


		for (int i = 0; i < 2; i++) {
			//GameObject newProduct1 = Instantiate (prod1, transform.position, Quaternion.identity) as GameObject;
			//GameObject newProduct2 = Instantiate (prod2, transform.position, Quaternion.identity) as GameObject;
			//products.Add (newProduct1);
			//products.Add (newProduct2);
		}



	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
