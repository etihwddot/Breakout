using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	public float Speed;
	public float MinimumX;
	public float MaximumX;

	private Rigidbody rigidbody;

	void Start()
	{
		rigidbody = GetComponent<Rigidbody>();
	}

	void Update()
	{
		var moveHorizontal = Input.GetAxis("Horizontal");
		rigidbody.transform.position = new Vector3(Mathf.Clamp(rigidbody.transform.position.x + (moveHorizontal * Speed), MinimumX, MaximumX), 0, 0);

	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag != "Ball")
			return;

		Debug.Log("Ball collision.");
	}
}
