using UnityEngine;
using System.Collections;

public class Homing : MonoBehaviour {

	public Transform target;
	public float rocketTurnSpeed;
	public float rocketSpeed;
	public float randomOffset;

	private float timerSinceLaunch_Contor;
	private float objectLifeTimerValue;

	// Use this for initialization
	void Start () 
	{
		//rocketTurnSpeed = 50.0f;
		//rocketSpeed = 45f;
		//randomOffset = 0.0f;
	}

	// Update is called once per frame
	void Update () 
	{
		if (target != null)
		{
				if ((target.position - transform.position).magnitude > 0)
				{
					randomOffset = 0f;
					rocketTurnSpeed = 90.0f;
				}

			Vector3 direction = target.position - transform.position + Random.insideUnitSphere * randomOffset;
			direction.Normalize();
			transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.LookRotation(direction), rocketTurnSpeed * Time.deltaTime);
			transform.Translate(Vector3.forward * rocketSpeed * Time.deltaTime);
		}
			
	}
}
