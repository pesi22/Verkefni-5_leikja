using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float targetX = transform.position.x;
        float targetY = transform.position.y;
        GetComponent<Rigidbody2D>().velocity = new Vector2(targetX + 0.1f, targetY);
    }
}
