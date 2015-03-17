using UnityEngine;
using System.Collections;

public class DestroyOnEnter : MonoBehaviour {

	void OnTriggerEnter(Collider other)
	{
		Destroy(other.gameObject);

		if (other.CompareTag("Ball"))
			GameManager.Instance.ResetBall();
	}
}
