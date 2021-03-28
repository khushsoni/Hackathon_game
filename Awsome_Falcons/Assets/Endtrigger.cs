
using UnityEngine;

public class Endtrigger : MonoBehaviour
{
	public GameManager gameManager;

	private void OnTriggerEnter ()
	{
		gameManager.CompleteLevel();
	}


}
