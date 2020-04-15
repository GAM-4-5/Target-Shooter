using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMotor : MonoBehaviour //uređivanje i podešavanje funkcija igrača
{

	[SerializeField]
	private Camera cam;

	private Vector3 rotation = Vector3.zero; //postavljanje mogućnosti rotacije puške
	private Vector3 cameraRotation = Vector3.zero; //postavljanje mogućnosti rotacije kamere 

	private Rigidbody rb;

	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}
		
		
	public void Rotate(Vector3 _rotation) //korištenje vektora rotacije puške
	{
		rotation = _rotation;
	}
		
	public void RotateCamera(Vector3 _cameraRotation) //korištenje vektora rotacije kamere
	{
		cameraRotation = _cameraRotation;
	}
		
	void FixedUpdate() //izvođenje funkcija vezanih uz fiziku
	{
		PerformRotation();
	}

		
	void PerformRotation() //izvođenje rotacije
	{
		rb.MoveRotation(rb.rotation * Quaternion.Euler(rotation)); 
		if (cam != null) 
		{
			cam.transform.Rotate(-cameraRotation);
		}
	}
}
