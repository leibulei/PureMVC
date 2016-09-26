using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class GameUtilty  {
	public static Transform GetChild(GameObject root,string path)
	{
		Transform tra = root.transform.Find (path);
		if (tra == null)
			Debug.Log (path + " not find");
		return tra;
	}
	public static T GetChildComponent<T>(GameObject root,string path){
		Transform tra = root.transform.Find (path);
		if (tra == null)
			Debug.Log (path + " not find");
		T t = tra.GetComponent<T> ();
		return t;
	}
}
