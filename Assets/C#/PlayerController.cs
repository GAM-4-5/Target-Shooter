using UnityEngine;


[RequireComponent(typeof(PlayerMotor))]
public class PlayerController : MonoBehaviour { //povezivanje miša i virtualnog igrača

	[SerializeField]
	private float lookSensitivity = 3f; //postavljanje vrijednosti prizora

	private PlayerMotor motor; 

	void Start()
	{
		motor = GetComponent<PlayerMotor>(); //povezivanje koda sa PlayerMotorom
	}

	void Update()
	{
		float _yRot = Input.GetAxisRaw("Mouse X"); //podešavanje mogućnosti okretanja 

		Vector3 _rotation = new Vector3(0f, _yRot, 0f) * lookSensitivity;

		motor.Rotate(_rotation); //primjena rotacije

		float _xRot = Input.GetAxisRaw("Mouse Y"); //podešavanje mogućnosti okretanja

		Vector3 _cameraRotation = new Vector3(_xRot, 0f, 0f) * lookSensitivity;

		motor.RotateCamera(_cameraRotation); //primjena rotacije kamere
	}
}
