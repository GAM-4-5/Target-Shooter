using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour 
{
	public float currentTime = 10f;

	[SerializeField] Text countdownText;

	void Update()
	{
		currentTime -= 1 * Time.deltaTime;
		countdownText.text = currentTime.ToString("0");

		if (currentTime <= 0)
		{
			currentTime = 0;
		}
	}
}
