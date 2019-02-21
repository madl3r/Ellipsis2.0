using UnityEngine;
using System.Collections;

public class lightningParent : BaseEnemy {


	public GameObject enemySpawn;
	public GameObject carrier1;
	public GameObject carrier2;
	public GameObject lightning;
	private float speed;
    private float startPause;
    private bool started;

    // Use this for initialization
    void Start () {
		if (worldSpawned)
			transform.position = new Vector2(Random.Range(8.0f, 11.0f), 0);

		speed = Random.Range(-3.0f, -4.5f);
        started = false;
        startPause = Time.time + 2;
        

		//rigidbody2D.velocity = new Vector2 (Random.Range(-3.0f, -5.0f), 0);
	}
	
	// Update is called once per frame
	void Update () {
        if (!started && Time.time > startPause)
        {
            carrier1.GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);
            carrier2.GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);
            lightning.GetComponent<Rigidbody2D>().velocity = new Vector2(speed, 0);
            started = true;
        }
    }

	protected override void OffCameraLeft()
	{
		//Should maybe also choose a new line to go onto.
		transform.position = new Vector2 (Random.Range(10.0f, 12.0f), transform.position.y);
	}

    protected override void takeDamage(int dmg)
    {
        anim.SetTrigger("TakeDamage");
        hp -= dmg;

        if (hp <= 0)
        {
            //Tell the world that you died. Don't tell the world we died because we spawn another one.
            //dahWorld.GetComponent<World>().enemyKilled();
            Destroy(gameObject);
        }
    }

    public void lightningDie(Vector2 deadPos)
	{
        //Don't count the death, because this enemy spawns another one after its death.
        if (deadPos.y > 0)
		{
			//spawn an basic shooty enemy at -4y
			GameObject e = Instantiate(enemySpawn, new Vector2(deadPos.x - 1.0f, -4.0f), Quaternion.identity) as GameObject;
			e.GetComponent<BaseEnemy>().isWorldSpawned(false);
			e.GetComponent<BaseEnemy>().setTheWorld(dahWorld);
		}
		else
		{
			//spawn a basic shooty at +4y
			GameObject e = Instantiate(enemySpawn, new Vector2(deadPos.x - 1.0f, 4.0f), Quaternion.identity) as GameObject;
			e.GetComponent<BaseEnemy>().isWorldSpawned(false);
			e.GetComponent<BaseEnemy>().setTheWorld(dahWorld);
		}


		Destroy(gameObject);
	}

	protected void OnTriggerEnter2D(Collider2D other)
	{
		//Do nothing... I guess parents get hit too when their kids are hit 
		;
	}

}
