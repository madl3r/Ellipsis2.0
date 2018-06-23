using UnityEngine;
using System.Collections;

public class yellowAttackTypeScript : attackTypeScript {

	// Use this for initialization
	protected override void Start () {
		defaultAttackSpeed = 2.0f;
		knockBackPos = -6.1f;
		knockBackSpeed = 0.0f;
		color = new Color(255f, 255f, 0f);
		base.Start();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
