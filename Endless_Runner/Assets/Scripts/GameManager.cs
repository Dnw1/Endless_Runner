using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public Transform platformGenerator;
	private Vector3 platformStartPoint;

	public Transform platformGenerator1;
	private Vector3 platformStartPoint1;

	public Transform platformGenerator2;
	private Vector3 platformStartPoint2;

	public Transform platformGenerator3;
	private Vector3 platformStartPoint3;

	public Player thePlayer;
	private Vector3 playerStartPoint;
	// Use this for initialization
	void Start () {
		platformStartPoint = platformGenerator.position;
		platformStartPoint1 = platformGenerator1.position;
		platformStartPoint2 = platformGenerator2.position;
		platformStartPoint3 = platformGenerator3.position;

		playerStartPoint = thePlayer.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void RestartGame()
	{
		StartCoroutine ("RestartGameCo");
	}

	public IEnumerator RestartGameCo()
	{
		thePlayer.gameObject.SetActive (false);
		yield return new WaitForSeconds (0.5f);
		thePlayer.transform.position = playerStartPoint;
		platformGenerator.position = platformStartPoint;
		platformGenerator1.position = platformStartPoint1;
		platformGenerator2.position = platformStartPoint2;
		platformGenerator3.position = platformStartPoint3;
		thePlayer.gameObject.SetActive (true);
	}
}
