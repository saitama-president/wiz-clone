using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;
using System.Reflection;

[CustomEditor(typeof(MasterObj<>),true)
]//拡張するクラスを指定
public class MasterEditor : Editor {

  private string search="search";

  public Common.Data D;
  
	public override void OnInspectorGUI(){


		base.OnInspectorGUI ();
		
    //ボタンを表示
    if (GUILayout.Button("Reload")){
      Debug.Log("押した!");

      
      Debug.Log($"TYPE={this.target.GetType()}"); 
      //読み出し
      

      
      MethodInfo method= this.target.GetType().GetMethod("Save");

      Debug.Log(method);
       method.Invoke(this.target,new object[]{});
      
    }
    TableGenerate(new string[]{"A","B","C","D","E"});
	}

  protected void TableGenerate(string[] columns){

    SeachField();
    FindedField(columns);
  }

  protected void SeachField(){
    EditorGUILayout.BeginHorizontal();
      GUILayout.Label("Search");
      this.search=GUILayout.TextField(this.search);

    EditorGUILayout.EndHorizontal();

  }

  protected void FindedField(string[] columns){

    //ヘッダ部分
    EditorGUILayout.BeginHorizontal();
    foreach(string column in columns){
      GUILayout.Label(column);
    }
    EditorGUILayout.EndHorizontal();

    //ボディ部分


  }

}
