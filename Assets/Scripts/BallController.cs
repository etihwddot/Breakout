using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour
{
	void Start ()
	{
		GetComponent<Rigidbody>().velocity = new Vector3 (4, 0, 15);
	}
}
