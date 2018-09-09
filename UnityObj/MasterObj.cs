using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Common;
using WIZC;
[System.Serializable]
public abstract class MasterObj<DATA> : MonoBehaviour 
	where DATA:Common.Data
{

	public List<Data> datas;
	public void Save(){
		Debug.Log("Call Save!");
		string path=$"{Application.streamingAssetsPath}{this.GetType().FullName}.json" ;

		Debug.Log(path);

	}

	public void Load(){
		Debug.Log("Call Save!");
		string path=$"{Application.streamingAssetsPath}{this.GetType().FullName}.json" ;

		Debug.Log(path);

	}
}

