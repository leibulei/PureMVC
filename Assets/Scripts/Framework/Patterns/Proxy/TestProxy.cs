using UnityEngine;
using System.Collections;
using PureMVC.Patterns;
public class TestProxy : Proxy {
	public new const string NAME="TestProxy";
	public CharacterInfo Info{ get; set;}
	public TestProxy():base(NAME){
		Info = new CharacterInfo ();
	}
	public void ChangeLevel(int value){
		Debug.Log("Proxy.changeLevel");
		Info.Level += value;
		SendNotification (NotificationConstant.LevelChange, Info);
	}
	public void ChangeHp(int value){
		Debug.Log("Proxy.changeHp");
		Info.Hp += value;
		SendNotification (NotificationConstant.HpChange, Info);
	}
}
