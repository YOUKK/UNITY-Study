using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Status : MonoBehaviour
{
    // public 일 때는 멤버변수가 화면에 그대로 드러난다
    // 근데 SOLID 단일책임원칙을 포기하는 것. 그니까 기호로 생각할 것
    // 어트리뷰트라는 문법을 지원하는데 이는 데이터의 처리형식을 지원해주는 문법이다.

    [SerializeField]
    private int m_HP = 100;

    [SerializeField]
    private int m_AT = 20;

    public int HP
    {
        get
        {
            return m_HP;
        }
        set
        {
            m_HP = value;
        }
    }

    public int AT
    {
        get
        {
            return m_AT;
        }
        set
        {
            m_AT = value;
        }
    }
}
