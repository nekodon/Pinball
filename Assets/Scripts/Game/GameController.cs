using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	public GameObject Root;
	public Transform Stage;
	public Transform ball;

	// Use this for initialization
	void Start ()
	{
		Root = GameObject.Find("Root");
		Stage = Root.transform.Find("Stage");
		ball = Stage.transform.Find("Ball");
		ball.GetComponent<Rigidbody>().Sleep();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnJoinRoom()
	{
		ball.GetComponent<Rigidbody>().WakeUp();
	}

}
