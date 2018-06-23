using UnityEngine;
using System.Collections;

public class attackTypeScript : MonoBehaviour
{
	//To be used for setting the default attack speed of the player that is currently using this attackType
	protected float defaultAttackSpeed;
	protected float knockBackPos;
	protected float knockBackSpeed;
	protected Color color;
	public GameObject bullet;
	public GameObject myPlayer;

	// Use this for initialization
	protected virtual void Start () {
		if (myPlayer != null)
		{
			myPlayer.GetComponent<playerStats>().setBaseAttackSpd(defaultAttackSpeed);
			myPlayer.GetComponent<playerStats>().setBullet(bullet);
			myPlayer.GetComponent<Movement>().setKnockBackPos(knockBackPos);
			myPlayer.GetComponent<playerStats>().setKnockBack(knockBackSpeed);
			myPlayer.GetComponent<SpriteRenderer>().color = color;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void setBaseAttackSpeed(GameObject attacker)
	{
		attacker.GetComponent<playerStats>().setBaseAttackSpd(defaultAttackSpeed);
	}

	public void givePlayerBullet(GameObject player)
	{
		player.GetComponent<playerStats>().setBullet(bullet);
	}
}
