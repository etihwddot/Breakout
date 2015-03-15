using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	public float Speed;

	void Update ()
	{
		var moveHorizontal = Input.GetAxis("Horizontal");
		GetComponent<Rigidbody>().velocity = new Vector3(moveHorizontal, 0, 0) * Speed;
	}
}
