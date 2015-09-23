using System;
using UnityEngine;

public class Camera2D : MonoBehaviour
{
	public Player thePlayer;

	private Vector3 lastPlayerPosition;
	public float distanceToMove;

	void Start()
	{
		thePlayer = FindObjectOfType<Player> ();
		lastPlayerPosition = thePlayer.transform.position;
	}
	void Update(){
		distanceToMove = thePlayer.transform.position.x - lastPlayerPosition.x;

		transform.position = new Vector3(transform.position.x + distanceToMove, transform.position.y, transform.position.z);

		lastPlayerPosition = thePlayer.transform.position;
	}
}