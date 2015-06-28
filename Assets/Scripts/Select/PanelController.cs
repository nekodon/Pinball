using UnityEngine;
using System.Collections;

public class PanelController : MonoBehaviour {


	void Awake()
	{
		this.GetComponent<uTools.uTweenPosition>().enabled = false;
	}

	public void Show()
	{
		this.GetComponent<uTools.uTweenPosition> ().enabled = true;
		this.GetComponent<uTools.uPlayTween> ().playDirection = uTools.PlayDirection.Forward;
		this.GetComponent<uTools.uPlayTween>().Play();
		this.gameObject.SetActive(true);
		Debug.Log ("show");
	}

	public void Hide()
	{
		this.GetComponent<uTools.uTweenPosition> ().enabled = true;
		this.GetComponent<uTools.uPlayTween> ().playDirection = uTools.PlayDirection.Reverse;
		this.GetComponent<uTools.uPlayTween>().Play();
	}


}
