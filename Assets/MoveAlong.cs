using UnityEngine;
using System.Collections;

public class MoveAlong : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void LateUpdate(){
		CountItHigher cih = this.gameObject.GetComponent<CountItHigher> ();
		if (cih != null) {
			float tX = cih.currentNum / 10f;
			Vector3 tempLoc = this.pos;
			tempLoc.x = tX;
			//tempLoc.y = 4; //fighting gravity
			this.pos = tempLoc;
		}
	}

	public Vector3 pos{
		get{
			return (this.transform.position);
		}
		set{
			this.transform.position = value;
		}
		
	}
}
