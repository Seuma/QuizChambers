using UnityEngine;

public class GameManager : MonoBehaviour
{
	[SerializeField] private GameObject panel;

	[SerializeField] private PlayerMovement player;

	/*
	 * Starting the game means the following:
	 *  - disabling the Hello plane and it's content
	 *  - enabling the character movement
	 */
	public void StartGame()
	{
		panel.SetActive(false);
		player.started = true;
	}
	
	/*
	 * Ending the game shall just quit it.
	 */
	public void EndGame()
	{
		Application.Quit();
	}
}