using UnityEngine;
using System.Collections;

public class EnemyController : MonoBehaviour
{
	public int HitPoints = 1;

	void OnTriggerEnter(Collider other)
	{
		if (!other.CompareTag("Ball"))
			return;

		HitPoints--;

		if (HitPoints == 0)
		{
			Destroy (gameObject);
			GameManager.Instance.DecrementEnemyCount();
		}
	}
}
