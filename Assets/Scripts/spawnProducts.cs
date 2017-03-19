using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnProducts : MonoBehaviour {

	Vector3 loc;

	Product[] products;

	// Use this for initialization
	void Start () {
		//products = new ArrayList ();

		GameObject productsObj = GameObject.Find ("ProductManager");
		GameObject instPoint = GameObject.Find ("prodInstPoint");
		products = productsObj.GetComponent<productManagement>().products;
		//Debug.Log(products[0].obj);
		//products = productManagement();
			
		loc = (instPoint.transform.position);

		Debug.Log ("Location: " + loc);

		for (int i = 0; i < 3; i++) {
			loc.z += Random.Range(-2f, 2f);
			//GameObject newProduct1 = Instantiate(products[Mathf.Round(Random(0,2))].obj, loc, Quaternion.identity) as GameObject;
			GameObject newProduct1 = Instantiate(products[0].obj, loc, Quaternion.identity) as GameObject;
//			GameObject newProduct2 = Instantiate (prod2, transform.position, Quaternion.identity) as GameObject;
		}



	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
