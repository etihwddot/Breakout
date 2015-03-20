using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour
{
	public GameObject BallPrefab;
	public Transform BallSpawnLocation;
	public static GameManager Instance;
	public int Level = 1;

	public GameObject EnemyPrefab;
	public float EnemyMinZ = 10;
	public float EnemyMaxZ = 23;
	public float EnemyMinX = -8;
	public float EnemyMaxX = 8;

	public int BallCount;

	private int EnemyCount;

	void Awake()
	{
		// TODO: handle new scenes
		Instance = this;

		for (int i = 0; i < BallCount; i++)
			ResetBall ();

		LayoutLevel(Level);
	}

	public void ResetBall()
	{
		GameObject ball = (GameObject) Instantiate(BallPrefab, BallSpawnLocation.position, Quaternion.identity);
		ball.transform.SetParent(BallSpawnLocation);
	}

	void LayoutLevel(int level)
	{
		EnemyCount = 0;

		for (int i = 0; i < level; i++)
		{
			float x = Random.Range(EnemyMinX, EnemyMaxX);
			float z = Random.Range(EnemyMinZ, EnemyMaxZ);

			var enemy = (GameObject)Instantiate (EnemyPrefab, new Vector3 (x, 0.25f, z), Quaternion.identity);
			EnemyCount++;
		}
	}

	public void DecrementEnemyCount()
	{
		EnemyCount--;

		if (EnemyCount == 0)
		{
			Level++;
			LayoutLevel(Level);
		}
	}
}
