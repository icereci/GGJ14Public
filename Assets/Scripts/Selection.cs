using UnityEngine;
using System.Collections;

public class Selection : MonoBehaviour {
	
	public int a;
	void OnMouseEnter(){
		
		renderer.material.color = Color.red;
	}
	
	void OnMouseExit(){
		
		renderer.material.color = Color.white;
	}
	
	void OnMouseDown(){
		
		if(a==1){
			Application.LoadLevel(3);
		}
		if(a==2){
			Application.LoadLevel(2);
		}
		if(a==3){
			Application.LoadLevel(6);
		}
		if(a==4){
			Application.LoadLevel(5);
		}
		if (a == 5) 
		{
			Application.LoadLevel(1);		}
		
		
		
	}
}
