using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	
	public string ui_name_scene;
	
	
	public void ChangeScene(string nameScene)
	{
		SceneManager.LoadScene(nameScene);
	}
	
	
}
