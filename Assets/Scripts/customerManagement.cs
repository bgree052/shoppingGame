using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Customer {

	public GameObject obj;
	public int mostSuitableAge;
	public int difficulty;
	public int probability;

}

public class customerManagement : MonoBehaviour {

	public Customer[] customers;

}
