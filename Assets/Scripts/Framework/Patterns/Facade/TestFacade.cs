using UnityEngine;
using System.Collections;
using PureMVC.Patterns;
public class TestFacade : Facade {
	public TestFacade(GameObject canvas){
		RegisterCommand (NotificationConstant.LevelUp, typeof(TestCommand));
		RegisterCommand (NotificationConstant.HpAdd, typeof(TestCommand1));
		RegisterMediator (new TestMediator (canvas));
		RegisterProxy (new TestProxy ());
	}
}