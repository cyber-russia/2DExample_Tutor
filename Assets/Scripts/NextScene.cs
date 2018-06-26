using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SupremumStudio
{
	public class NextScene : MonoBehaviour
	{
		[Header("Введите номер следующей сцены для загрузки")]
		public int NextLoadScene;
		
		
		private void OnTriggerEnter2D(Collider2D other)
		{
			if (other.tag == "Player")
			{
				UnityEngine.SceneManagement.SceneManager.LoadScene(NextLoadScene);		
			}
		}
		
	}
}