using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PenguinScript : MonoBehaviour
{
	[SerializeField] 
	private float speed = 1.0f;
	[SerializeField] 
	private float jumpPower = 3.0f;
    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < Gamepad.all.Count; i++)
		{
			Debug.Log(Gamepad.all[i].name);
		}
    }

    // Update is called once per frame
    void Update()
    {
		//Debug.Log(Time.deltaTime);
		if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
		{
			transform.position += Vector3.right * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
		{
			transform.position += Vector3.left * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
		{
			transform.position += Vector3.forward * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
		{
			transform.position += Vector3.back * speed * Time.deltaTime;
		}
		if (Input.GetKey(KeyCode.Space))
		{
			if(transform.position.y <= 1.0f)
			{
				transform.position += Vector3.up * jumpPower * Time.deltaTime;
			}
		}

		if(Gamepad.all.Count > 0)
		{
			if(Gamepad.all[0].leftStick.left.isPressed)
			{
				transform.position += Vector3.right * speed * Time.deltaTime;
			}
			if(Gamepad.all[0].leftStick.right.isPressed)
			{
				transform.position += Vector3.left * speed * Time.deltaTime;
			}
			if(Gamepad.all[0].leftStick.up.isPressed)
			{
				transform.position += Vector3.forward * speed * Time.deltaTime;
			}
			if(Gamepad.all[0].leftStick.down.isPressed)
			{
				transform.position += Vector3.back * speed * Time.deltaTime;
			}
			if(Gamepad.all[0].buttonSouth.isPressed || Gamepad.all[0].dpad.up.isPressed)
			{
				if(transform.position.y <= 1.0f)
				{
					transform.position += Vector3.up * jumpPower * Time.deltaTime;
				}
			}
			if(Gamepad.all[0].leftStickButton.isPressed || Gamepad.all[0].rightStickButton.isPressed)
			{
				if(transform.position.y <= 2.0f)
				{
					transform.position += Vector3.up * jumpPower * Time.deltaTime;
				}
			}
			if(Gamepad.all[0].startButton.isPressed || Gamepad.all[0].selectButton.isPressed)
			{
				if(transform.position.y <= 0.5f)
				{
					transform.position += Vector3.up * jumpPower * Time.deltaTime;
				}
			}
			if(Gamepad.all[0].leftShoulder.isPressed)
			{
				transform.eulerAngles -= new Vector3(0.0f, speed, 0.0f);
			}
			if(Gamepad.all[0].rightShoulder.isPressed)
			{
				transform.eulerAngles += new Vector3(0.0f, speed, 0.0f);
			}
		}
    }
}
