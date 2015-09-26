using UnityEngine;
using System.Collections;

public class P1_Follow : MonoBehaviour {

	private NavMeshAgent player;

	RaycastHit hit;
	Ray ray;
	

	// Use this for initialization
	void Start () {
		player = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
		Movement ();
	}

	void Movement(){
		ray = Camera.main.ScreenPointToRay(Input.mousePosition);
		if (Physics.Raycast (ray, out hit, 1000)) {
			player.destination = hit.point;
		}


	}
}
