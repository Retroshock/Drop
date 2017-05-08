using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	private float moveHorizontal;
	private float moveVertical;
	public float speed;


	void Start ()
	{
		StartCoroutine (PlayerLock ());
	}
	void Update()
	{
		transform.position=new Vector3(Mathf.Clamp (transform.position.x, -6.2f, 6.2f),transform.position.y, transform.position.z);
	}
	void FixedUpdate()
	{

		Rigidbody rb = GetComponent<Rigidbody> ();
		moveHorizontal = Input.GetAxis ("Horizontal");
		Vector3 movement = new Vector3 (moveHorizontal, 0, 0);
		rb.AddForce (movement*speed);

	}
	IEnumerator PlayerLock()
	{
		Rigidbody rb = GetComponent<Rigidbody> ();
		rb.useGravity = false;
		yield return new WaitForSeconds(10f);
		rb.useGravity = true;
	}
}
