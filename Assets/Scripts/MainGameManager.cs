using UnityEngine;
using System.Collections;

public class MainGameManager : MonoBehaviour {

	public static int MULTI_PLAY = 0;//0:solo, 1:murti
	public static int PLAYERS_COUNT = 1;//1 or 2 or 4
	public static int FIGHT_MODE = 0;//0:協力 1:対戦 

	public static int GetMultiPlay()
	{
		return MULTI_PLAY;
	}

	public static void SetMultiPlay(int num)
	{
		MULTI_PLAY = num;
	}

	public static int GetPlayersCount()
	{
		return PLAYERS_COUNT;
	}
	
	public static void SetPlayersCount(int num)
	{
		PLAYERS_COUNT = num;
	}

	public static int GetFightMode()
	{
		return FIGHT_MODE;
	}
	
	public static void SetFightMode(int num)
	{
		FIGHT_MODE = num;
	}


	public static void ResetStatics()
	{
		MULTI_PLAY = 0;
		PLAYERS_COUNT = 1;
		FIGHT_MODE = 0;
	}
	



}
