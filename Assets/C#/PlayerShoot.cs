using UnityEngine;
using UnityEngine.UI;

public class PlayerShoot : MonoBehaviour
{

	public PlayerMotor motor; //uvođenje ili definiranje funkcije pokreta igrača
	public PlayerController controller; //uvođenje ili definiranje funkcije kojom usklađujemo pomak miša i fokus kamere

	public GameObject cup2; //uvođenje ili definiranje coffee to go čaša
	public GameObject cup3;
	public GameObject cup4;
	public GameObject cup5;
	public GameObject cup6;
	public PlayerWeapon weapon; //uvođenje ili definiranje oružja, tj. puške
	public int range = 1000; //domet metka

	public Text ScoreText; //prikaz trenutnog rezultata
	public Text FinaleScore; //prikaz završnog ili konačnog rezultata
	public Text countdownText; //prikaz trenutne vrijednosti timera
	public float currentTime = 10f; //početno vrijeme od kojeg započinje odbrojavanje

	public GameObject text; //završni tekst

	public int Hits; //uvođenje ili definiranje hitaca, tj. pucnjeva

	public Camera cam; //uvođenje ili definiranje kamere

	void Start()
	{
		
		if (cam == null) 
		{
			Debug.LogError("PlayerShoot: No camera referenced!");
			this.enabled = false;
		}
		text.SetActive(false); //onemogućavanje prikazivanja završnog teksta do trenutka kada završimo igrati
	}

	void Update()
	{
		if (Input.GetButtonDown("Fire1")) { //početak odbrojavanja
			Shoot();
		}
		ScoreText.text = Hits.ToString();
		currentTime -= 1 * Time.deltaTime;

		if (currentTime <= 0)
		{
			currentTime = 0; //postavljanje ograničenja pokreta i kontrole nad kamerom kada vrijednost timera bude jednaka nuli
			motor.enabled = false;
			controller.enabled = false;
			text.SetActive(true);
			countdownText.text = Hits.ToString("0");
		}
	}	

	void Shoot()
	{
		RaycastHit _hit;
		if (Physics.Raycast(cam.transform.position, cam.transform.forward, out _hit, range)) { //određivanje posljedica kada pogodimo coffee to go čašu, tj. kada ju pogodimo, ona će nestati, a rezultat će se povećati za 1
			Debug.Log(_hit.collider.tag);
			}
			if (_hit.collider.name == "Cup2") {
				Destroy (cup2);
				Hits += 1;
			}
			if (_hit.collider.name == "Cup3") {
				Destroy(cup3);
				Hits += 1;
			}
			if (_hit.collider.name == "Cup4") {
				Destroy(cup4);
				Hits += 1;
			}
			if (_hit.collider.name == "Cup5") {
				Destroy(cup5);
				Hits += 1;
			}
			if (_hit.collider.name == "Cup6") {
				Destroy(cup6);
				Hits += 1;
			}
			
		}
	}

