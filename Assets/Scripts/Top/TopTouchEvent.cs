using UnityEngine;
using System.Collections;

public class TopTouchEvent : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnTapStartButton()
	{
		Debug.Log("OnTapStartButton");
		Application.LoadLevel("SelectScene");
	}

}
