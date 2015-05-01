using UnityEngine;
using System.Collections;

public class EnemyZig : Enemy {

	private Vector3 origPos;
	private float startOffset;

	void Start(){
		this.origPos = this.pos;
		this.speed = Random.value * 5;
		this.startOffset = Random.value;
	}

	public override void Move()
	{
		//print (Time.time);
		Vector3 tempPos = this.pos;
		tempPos.x = (Mathf.Sin ((Time.time + this.startOffset) * Mathf.PI) * (this.speed*4)) + this.origPos.x;
		tempPos.z = (Mathf.Cos ((Time.time + this.startOffset) * Mathf.PI) * (this.speed*4)) + this.origPos.z;
		this.pos = tempPos;
		this.gameObject.transform.Rotate (this.speed*2, this.speed*2, this.speed*2);
		base.Move ();
	}
}
