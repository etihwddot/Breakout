using UnityEngine;
using System.Collections;

public class BallController : MonoBehaviour
{
	private bool isLaunched = false;

	void Update()
	{
		if (!isLaunched && Input.GetKeyDown(KeyCode.Space))
		{
			transform.SetParent(null);
			GetComponent<Rigidbody>().velocity = new Vector3(4, 0, 12);
			isLaunched = true;
		}
	}


	void OnDestroy()
	{
		GameManager.Instance.ResetBall ();
	}
}
