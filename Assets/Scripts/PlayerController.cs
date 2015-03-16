using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	public float Speed;
	public float MinimumX;
	public float MaximumX;

	void Update()
	{
		var moveHorizontal = Input.GetAxis("Horizontal");
		var rigidbody = GetComponent<Rigidbody>();
		rigidbody.transform.position = new Vector3(Mathf.Clamp(rigidbody.transform.position.x + (moveHorizontal * Time.deltaTime * Speed), MinimumX, MaximumX), 0, 0);

	}

	void OnTriggerEnter(Collider other)
	{
		if (other.tag != "Ball")
			return;

		Debug.Log("Ball collision.");
	}
}
