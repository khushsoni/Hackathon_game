using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{

	public CubeScript cubeScript;

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "SphereCollects")
		{
			Destroy(other.gameObject);
		}
	}

	private void OnCollisionEnter(Collision other)
	{
		if(other.gameObject.tag == "Obstacles")
		{
			cubeScript.enabled = false;
		}
	}

}
