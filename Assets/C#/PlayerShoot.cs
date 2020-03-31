using UnityEngine;
using UnityEngine.UI;

public class PlayerShoot : MonoBehaviour
{

	public PlayerMotor motor;
	public PlayerController controller;

	public GameObject cup2;
	public GameObject cup3;
	public GameObject cup4;
	public GameObject cup5;
	public GameObject cup6;
	public PlayerWeapon weapon;
	public int range = 1000;

	public Text ScoreText;
	public Text FinaleScore;
	public Text countdownText;
	public float currentTime = 10f;

	public GameObject text;

	public int Hits;

	public Camera cam;

	void Start()
	{
		
		if (cam == null) 
		{
			Debug.LogError("PlayerShoot: No camera referenced!");
			this.enabled = false;
		}
		text.SetActive(false);
	}

	void Update()
	{
		if (Input.GetButtonDown("Fire1")) {
			Shoot();
		}
		ScoreText.text = Hits.ToString();
		currentTime -= 1 * Time.deltaTime;

		if (currentTime <= 0)
		{
			currentTime = 0;
			motor.enabled = false;
			controller.enabled = false;
			text.SetActive(true);
			countdownText.text = Hits.ToString("0");
		}
	}	

	void Shoot()
	{
		RaycastHit _hit;
		if (Physics.Raycast(cam.transform.position, cam.transform.forward, out _hit, range)) {
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

