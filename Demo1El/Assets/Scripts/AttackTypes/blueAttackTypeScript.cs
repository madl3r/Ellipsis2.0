using UnityEngine;
using System.Collections;

public class blueAttackTypeScript : attackTypeScript {

	// Use this for initialization
	protected override void Start () {
		defaultAttackSpeed = 5.0f;
		knockBackPos = -6.15f;
		knockBackSpeed = -12.5f;
		color = new Color(0f, 0f, 255f);
		base.Start();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
