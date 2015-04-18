using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Enemy : MonoBehaviour {

	public float speed = 10f;
	public float fireRate = 0.3f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Move ();
	}

	public virtual void Move()
	{
		Vector3 tempPos = pos;
		tempPos.y -= speed * Time.deltaTime;
		pos = tempPos;
	}

	void OnCollisionEnter (Collision coll)
	{
		GameObject other = coll.gameObject;
		switch (other.tag) {
		case "Hero":
			//kill the hero
			break;
		case "HeroLaser":
			Destroy (this.gameObject);
			break;
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

	public Quaternion rot{
		get{
			return (this.transform.rotation);
		}
		set{
			this.transform.rotation = value;
		}
	}


}
