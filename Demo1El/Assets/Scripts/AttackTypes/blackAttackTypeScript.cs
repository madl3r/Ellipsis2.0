using UnityEngine;
using System.Collections;

public class blackAttackTypeScript : attackTypeScript {

	// Use this for initialization
	protected override void Start ()
	{
		defaultAttackSpeed = 4.0f;
		knockBackPos = -6.1f;
		knockBackSpeed = -12.5f;
		color = new Color(0f, 0f, 0f);
		base.Start();
	}	
	
	// Update is called once per frame
	void Update () {
		
	}
}
