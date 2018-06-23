using UnityEngine;
using System.Collections;

public class magentaAttackTypeScript : attackTypeScript {

	// Use this for initialization
	protected override void Start () {
		defaultAttackSpeed = 4.0f;
		knockBackPos = -6.5f;
		knockBackSpeed = -14.0f;
		color = new Color(255f, 0f, 255f);
		base.Start();	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
