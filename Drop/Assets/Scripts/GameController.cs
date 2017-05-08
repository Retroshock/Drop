using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public GameObject platform;
	public Transform spawnPos;
	public float Frequency;
	public bool GameOver=false;
	void Start () {
		StartCoroutine (PlatformSpawn () );

	}

	IEnumerator PlatformSpawn ()
	{
		while (true&&!GameOver)
		{
			Instantiate(platform,spawnPos.position,Quaternion.identity);
			yield return new WaitForSeconds(Frequency);
		}
	}
}
