using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace SupremumStudio
{
	
	public class Teleporter : MonoBehaviour
	{
		public Transform TeleportZone;
		private void OnTriggerEnter2D(Collider2D other)
		{
			if (other.tag == "Player")
			{
				other.transform.position = TeleportZone.transform.position;
			}
		}
	}
}