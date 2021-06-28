using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MoveCamera : MonoBehaviour
{
	private static Vector3 StartPos = Vector3.zero;
	private static MoveCamera GameCamera = null;
	public static Camera CamCom;
	public static void CameraReset()
	{
		GameCamera.transform.position = StartPos;
	}
	
	private void Awake()
	{
		Debug.Log("카메라 어웨이크");
		CamCom = GetComponent<Camera>();
		StartPos = transform.position;
		GameCamera = this;
	}


	// Update is called once per frame
	void Update()
    {
		// 앞에 this가 붙는다는 것을 잊지 말기
		transform.position += MyVector3.Right * Time.deltaTime * LogicValue.MoveSpeed;
    }
}
