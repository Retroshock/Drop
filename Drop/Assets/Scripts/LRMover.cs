using UnityEngine;
using System.Collections;

public class LRMover : MonoBehaviour {

	public float upSpeed;
	private float speed;
	private float LRSet;
	private float spawnPos;
	void Start () {
		if (Random.value > 0.5)
			LRSet = 0.1f;
		else
			LRSet = -0.1f;

		spawnPos = Random.Range (-4.65f, 4.65f);
		transform.position = new Vector3 (spawnPos, -11, 0);
		speed = Random.Range (15, 100);
	}
	

	void Update () {

		transform.position = new Vector3 (Mathf.Clamp(transform.position.x + LRSet*speed*Time.deltaTime,-4.65f,4.65f), transform.position.y + upSpeed*Time.deltaTime, 0f);
		if (transform.position.x == 4.65f || transform.position.x == -4.65f)
			LRSet *= -1;
	}

}
