using UnityEngine;
using System.Collections;

public class SelectTouchEvent : MonoBehaviour {

	private GameObject uiCanvas;
	private GameObject firstPanel;
	private GameObject secondPanel;
	private GameObject thirdPanel;
	private GameObject backButton;
	public int PageCount = 0;//


	// Use this for initialization
	void Start () {
		uiCanvas = GameObject.Find("Canvas");
		firstPanel = uiCanvas.transform.Find("FirstPanel").gameObject;
		secondPanel = uiCanvas.transform.Find("SecondPanel").gameObject;
		secondPanel.SetActive(false);
		thirdPanel = uiCanvas.transform.Find("ThirdPanel").gameObject;
		thirdPanel.SetActive(false);
		backButton = uiCanvas.transform.Find("BackButton").gameObject;
		backButton.SetActive(false);

		firstPanel.GetComponent<uTools.uTweenPosition>().enabled = true;
	}
	
	// Update is called once per frame
	void Update(){
	
	}

	public void SoloPlayButtonOnClick()
	{
		Debug.Log("SoloPlayButtonOnClick");
		MainGameManager.SetMultiPlay(0);
		//sologamesceneへ
		Debug.Log("Goto SoloPlayScene");

		//PageCount++;
		//PageMove();
	}

	public void MultiPlayButtonOnClick()
	{
		Debug.Log ("MultiPlayButtonOnClick");
		MainGameManager.SetMultiPlay(1);
		PageCount++;
		PageMove();
	}

	public void CoopButtonOnClick()
	{
		Debug.Log ("CoopButtonOnClick");
		MainGameManager.SetFightMode(0);
		MainGameManager.SetPlayersCount(2);
		Debug.Log("Goto MultiPlayScene");

	}
	
	public void BattleButtonOnClick()
	{
		Debug.Log ("BattleButtonOnClick");
		MainGameManager.SetFightMode(1);
		PageCount++;
		PageMove();
	}

	public void TwoButtonOnClick()
	{
		Debug.Log ("TwoButtonOnClick");
		MainGameManager.SetFightMode(1);
		MainGameManager.SetPlayersCount(2);
		Debug.Log("Goto MultiPlayScene");
		Debug.Log("Photon Login Start");
	}

	public void FourButtonOnClick()
	{
		Debug.Log("FourButtonOnClick");
		MainGameManager.SetFightMode(1);
		MainGameManager.SetPlayersCount(4);
		Debug.Log("Goto MultiPlayScene");
		Debug.Log("Photon Login Start");
	}


	public void ShowBackButton()
	{
		backButton.SetActive(true);
	}

	public void HideBackButton()
	{
		backButton.SetActive(false);
	}

	public void BackButtonOnClick()
	{
		Debug.Log("BackButtonOnClick");
		PageCount--;
		PageMove();
	}

	public void PageMove()
	{
		switch(PageCount){
			case 0:
				firstPanel.GetComponent<PanelController>().Show();
				secondPanel.GetComponent<PanelController>().Hide();
				HideBackButton();
			break;
			case 1:
				secondPanel.GetComponent<PanelController>().Show();
				firstPanel.GetComponent<PanelController>().Hide();
				thirdPanel.GetComponent<PanelController>().Hide();
				ShowBackButton();
			break;
			case 2:
				secondPanel.GetComponent<PanelController>().Hide();
				thirdPanel.GetComponent<PanelController>().Show();
			break;
		}
	}





}
