using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MoveCamera : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // �տ� this�� �ٴ´ٴ� ���� ���� ����
        transform.position += MyVector3.Right * Time.deltaTime;
    }
}
