using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoringSystem : MonoBehaviour
{
	public GameObject Score;
	public int theScore;

	private void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "SphereCollects")
		{
			theScore += 1;
			Score.GetComponent<Text>().text = "Score: " + theScore;
		}
	}
}
