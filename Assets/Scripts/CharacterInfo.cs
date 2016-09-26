using UnityEngine;
using System.Collections;

public class CharacterInfo {
	public int Level{ get; set;}
	public int Hp{ get; set;}
	public CharacterInfo(){
		Level = 1;
		Hp = 100;
	}
	public CharacterInfo(int levelchange,int hpchange){
		Level=levelchange;
		Hp = hpchange;
	}
}
