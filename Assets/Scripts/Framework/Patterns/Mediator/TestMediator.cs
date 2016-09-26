using UnityEngine;
using System.Collections;
using PureMVC.Patterns;
using UnityEngine.UI;
using System.Collections.Generic;
public class TestMediator : Mediator {
	public new const string NAME="TestMediator";
	private Text levelText;
	private Button levelUpBtn;
	private Text HpText;
	private Button HpAddBtn;

	public TestMediator(GameObject root):base(NAME)
	{
		levelText=GameUtilty.GetChildComponent<Text>(root,"levelText");
		levelUpBtn=GameUtilty.GetChildComponent<Button>(root,"levelUpBtn");
		HpText=GameUtilty.GetChildComponent<Text>(root,"HpText");
		HpAddBtn=GameUtilty.GetChildComponent<Button>(root,"HpAddBtn");
		levelUpBtn.onClick.AddListener(OnClickLevelUpBtn);
		HpAddBtn.onClick.AddListener(OnClickHpAddBtn);
	}
	private void OnClickHpAddBtn(){
		Debug.Log("hpBtn Click");
		SendNotification (NotificationConstant.HpAdd);
	}
	private void OnClickLevelUpBtn(){
		Debug.Log("levelBtn Click");
		SendNotification(NotificationConstant.LevelUp);
	}
	public override IList<string> ListNotificationInterests(){
		IList<string> list = new List<string>();
		list.Add (NotificationConstant.LevelChange);
		list.Add (NotificationConstant.HpChange);
		return list;
	}
	public override void HandleNotification(PureMVC.Interfaces.INotification notification){
		CharacterInfo ci=notification.Body as CharacterInfo;
		switch (notification.Name) {
		case NotificationConstant.LevelChange:
			Debug.Log("mediator.changelevel"+ci.Level);
			levelText.text=ci.Level.ToString();
			break;
		case NotificationConstant.HpChange:
			Debug.Log("mediator.changelhp"+ci.Hp);
			HpText.text=ci.Hp.ToString();
			break;
		default:
			break;
		}
	}
}
