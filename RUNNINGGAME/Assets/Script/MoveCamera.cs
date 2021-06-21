using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MoveCamera : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        // 앞에 this가 붙는다는 것을 잊지 말기
        transform.position += MyVector3.Right * Time.deltaTime;
    }
}
