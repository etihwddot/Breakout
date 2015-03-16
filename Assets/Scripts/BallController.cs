using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour
{
	private bool isLaunched;

	void Update()
	{
		if (!isLaunched && Input.GetKeyDown (KeyCode.Space))
		{
			GetComponent<Rigidbody>().velocity = new Vector3(4, 0, 12);
		}
	}


	void OnDestroy()
	{
		GameManager.Instance.ResetBall ();
	}
}
