using UnityEngine;
using System.Collections;

public class Switch_party : MonoBehaviour {

	public GameObject p1;
	public GameObject p2;
	public GameObject p3;
	public GameObject p4;

	public string slot1;
	public string slot2;
	public string slot3;
	public string slot4;

	string actual;

	Transform lastParent;

	// Use this for initialization
	void Start () {
		actual = slot1;
	}
	
	// Update is called once per frame
	void Update () {
		Hotkey_Control ();
	}

	void Hotkey_Control(){
		if(Input.GetKeyDown("q")){

			if(actual != slot1){
				lastParent = GameObject.FindGameObjectWithTag(slot1).transform.parent;
				GameObject.FindGameObjectWithTag(slot1).transform.parent = p1.transform;
				GameObject.FindGameObjectWithTag(actual).transform.parent = lastParent.transform;
				lastParent = null;
				actual = slot1;
			}
		}

		if(Input.GetKeyDown("w")){
			if(actual != slot2){
				lastParent = GameObject.FindGameObjectWithTag(slot2).transform.parent;
				GameObject.FindGameObjectWithTag(slot2).transform.parent = p1.transform;
				GameObject.FindGameObjectWithTag(actual).transform.parent = lastParent.transform;
				lastParent = null;
				actual = slot2;
			}
		}

		if(Input.GetKeyDown("e")){
			if(actual != slot3){
				lastParent = GameObject.FindGameObjectWithTag(slot3).transform.parent;
				GameObject.FindGameObjectWithTag(slot3).transform.parent = p1.transform;
				GameObject.FindGameObjectWithTag(slot3).transform.localPosition = p1.transform.localPosition;
				GameObject.FindGameObjectWithTag(actual).transform.parent = lastParent.transform;
				lastParent = null;
				actual = slot3;
			}
		}

		if(Input.GetKeyDown("r")){
			if(actual != slot4){
				lastParent = GameObject.FindGameObjectWithTag(slot4).transform.parent;
				GameObject.FindGameObjectWithTag(slot4).transform.parent = p1.transform;
				GameObject.FindGameObjectWithTag(actual).transform.parent = lastParent.transform;
				lastParent = null;
				actual = slot4;
			}
		}
	}
}
