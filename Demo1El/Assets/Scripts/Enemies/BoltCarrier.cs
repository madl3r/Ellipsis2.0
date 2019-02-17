using UnityEngine;
using System.Collections;

public class BoltCarrier : BaseEnemy {

	public GameObject theParent;
	private bool recentlyDamaged;
	private float attackTime;
	private float timeBtwnAttacks;
	// Use this for initialization
	void Start () {
		recentlyDamaged = false;
		timeBtwnAttacks = 0.5f;

		hp = 2;
		dmg = 2;
	}
	
	// Update is called once per frame
	void Update () {
		if (recentlyDamaged && (Time.time - attackTime) > timeBtwnAttacks)
			recentlyDamaged = false;
		
	}

	//TODO should also kill the parent so that all things attached die
	//(Maybe have the remaining player turn into a basicShootyEnemy?
	protected override void takeDamage(int dmg)
	{
		hp -= dmg;
		
		if (hp <= 0)
		{

			theParent.GetComponent<lightningParent>().lightningDie(transform.position);
			Destroy(gameObject);
		}
	}

	protected override void OffCameraLeft()
	{
		transform.position = new Vector2 (11.0f, transform.position.y);
	}

	protected void OnTriggerEnter2D(Collider2D other)
	{


		//if we're hitting a player, and we haven't recently damaged them then deal damage.
		if (other.gameObject.tag == "Player" && !recentlyDamaged)
		{
			recentlyDamaged = true;
			other.gameObject.SendMessage("takeDamage", dmg);
			//wait half a second before being able to deal damage again
			
			attackTime = Time.time;
			//Make noise and some effect
		}
		if (other.gameObject.tag == "bullet")
		{
			other.gameObject.SendMessage("dealDamage", gameObject);
		}
	}
	
}
