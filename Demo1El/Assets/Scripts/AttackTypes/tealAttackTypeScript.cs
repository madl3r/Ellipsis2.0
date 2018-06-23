using UnityEngine;
using System.Collections;

public class tealAttackTypeScript : attackTypeScript {

	// Use this for initialization
	protected override void Start () {
		defaultAttackSpeed = 3.5f;
		knockBackPos = -6.1f;
		knockBackSpeed = -10.0f;
		color = new Color(0f, 255f, 255f);
		base.Start();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
