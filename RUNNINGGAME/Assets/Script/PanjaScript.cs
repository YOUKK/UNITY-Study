using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanjaScript : MonoBehaviour
{
	private void Start()
	{
		
	}

	private void Update()
	{
		if (Player.PlayerPos.x - transform.position.x >= 10.0f)
		{
			// gameObject : ���� ������ �ִ� ������Ʈ
			Destroy(gameObject);
		}
	}
}
