using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DestroyByBoundary : MonoBehaviour {
	public Text ScoreText;
	private int count;
	private GameController gameController;
	public Text GameOverText;
	public Text Retry;
	void Start()
	{

		count = 0;
	}

	void Update()
	{
		if (Input.GetKeyDown(KeyCode.R))
			Application.LoadLevel(Application.loadedLevel);
	}

	void OnTriggerExit (Collider other)
	{
		GameObject gameControllerObject = GameObject.FindWithTag("GameController");
		if (gameControllerObject != null) {
			gameController = gameControllerObject.GetComponent<GameController> ();
			if (other.tag=="Player")
				gameController.GameOver=true;
		}
		if (other.tag == "Platform"&&gameController.GameOver==false) {
			count++;
			ScoreText.text="Score: "+count.ToString();
		}
		Destroy (other.gameObject);
		if (gameController.GameOver == true) {
			ScoreText.text = null;
			GameOverText.text="Your Score: "+count;
			Retry.text="Press R to retry";

		}

	}
}
