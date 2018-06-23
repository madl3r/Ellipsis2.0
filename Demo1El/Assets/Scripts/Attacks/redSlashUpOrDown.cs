﻿using UnityEngine;
using System.Collections;


//TODO Depricated script, not using anymore
public class redSlashUpOrDown : BaseBulletScript {


	public float upOrDown;

	// Use this for initialization
	void Start () {
		startTime = Time.time;
		dmg = 2 + bnsDmg;
		bulletSpeed = 5f + bnsBulletSpeed;
		duration = 0.5f + bnsDuration;
		GetComponent<Rigidbody2D>().velocity = new Vector2 (0, (bulletSpeed * upOrDown));
	}
	
	// Update is called once per frame
	void Update () {
		if (Time.time - startTime > duration)
		{
			//Destroy(transform.parent.gameObject);
			Destroy(gameObject);
		}
		
	}
	
	void FixedUpdate()
	{
		//transform.position = new Vector2 (transform.position.x, transform.position.y + 0.025f);
	}
	
	
	protected override void dealDamage(GameObject theHit)
	{
		if (theHit.tag == "enemy")
		{
			theHit.SendMessage("takeDamage", dmg);
			Destroy(gameObject);
		}
		else if (theHit.tag == "enemyBullet")
		{
			//Destory the bullet
			Destroy(theHit);
		}
	}
}
