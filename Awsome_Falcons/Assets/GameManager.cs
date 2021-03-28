
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	bool gameHasended = false;

	public GameObject completeLevelUI;

	public void CompleteLevel()
	{
		completeLevelUI.SetActive(true);
	}
	
	public void Endgame()
	{
		if (gameHasended == false)
		{
			gameHasended = true;
			Debug.Log("Game Over");
			Restart();
		}
		
		void Restart()
		{
			SceneManager.LoadScene(SceneManager.GetActiveScene().name);
		}
	}

}
