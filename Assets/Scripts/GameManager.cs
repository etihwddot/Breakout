using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
	public GameObject BallPrefab;
	public Transform BallSpawnLocation;
	public static GameManager Instance;

	public int BallCount;

	void Awake()
	{
		// TODO: handle new scenes
		Instance = this;

		for (int i = 0; i < BallCount; i++)
			ResetBall ();
	}

	public void ResetBall()
	{
		Instantiate(BallPrefab, BallSpawnLocation.position, Quaternion.identity);
	}
}
