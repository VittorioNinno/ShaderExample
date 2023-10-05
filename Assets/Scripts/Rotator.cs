using UnityEngine;

public class Rotator : MonoBehaviour
{
	[Header("Rotation Settings")]
	[Tooltip("The object to rotate.")]
	[SerializeField] private Transform objectToRotate;

	[Tooltip("Rotation speed in degrees per second.")]
	[SerializeField] private float rotationSpeed = 50.0f;

	void Start()
	{
		objectToRotate = GetComponent<Transform>();
	}
	void Update()
	{
		//	Calculate the rotation angle based on speed and time
		float rotationAngle = rotationSpeed * Time.deltaTime;

		//	Rotate the specified object around the Y-axis
		objectToRotate.Rotate(Vector3.up * rotationAngle);
	}
}
