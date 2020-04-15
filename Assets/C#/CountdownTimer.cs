using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour //postavljanje timera
{
	public float currentTime = 10f; //početno vrijeme od kojega započinje odbrojavanje

	[SerializeField] Text countdownText; //ispisivanje vrijednosti timera

	void Update()
	{
		currentTime -= 1 * Time.deltaTime; //smanjivanje vrijednosti timera za jedan (sekunda)
		countdownText.text = currentTime.ToString("0"); //prva vrijednost timera prije nego što započne odbrojavanje

		if (currentTime <= 0) //naredba da se timer "zakoči" kada vrijednost timera bude jednaka nuli ili manja od nule (odbrojavanje inače ide u negativne vrijednosti)
		{
			currentTime = 0;
		}
	}
}
