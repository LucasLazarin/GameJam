using UnityEngine;
using System.Collections;

public class Party_Follow : MonoBehaviour {
	
	private NavMeshAgent partymember;
	
	RaycastHit hit;
	Ray ray;

	public GameObject place_target;
	
	
	// Use this for initialization
	void Start () {
		partymember = GetComponent<NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
		Follow (place_target);
	}
	
	void Follow(GameObject target){
		partymember.destination = target.transform.position;	
		
	}
}
