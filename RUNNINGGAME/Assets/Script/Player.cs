using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//class Test
//{
//    int Number;

//    public void Func
//    {
//        Number = 1000;
//    }
//}


// ���ϸ�� ������ Ŭ������ �ϳ��� �ְ�
// : MonoBehavior�� ��ӹ޾ƾ� ��ũ��Ʈ�μ�
// GameObject�� �־��ִ� ���� �����ϴ�.

public struct MyVector3
{
    static Vector3 m_Right = new Vector3(1.0f, 0.0f, 0.0f);
    public static Vector3 Right
    {
        get
        {
            return m_Right;
        }
    }
}

public class Player : MonoBehaviour
{
    //Player()
    //{
    //    UnityEngine.Debug.Log("������");
    //}

    //void Awake()
    //{
    //    UnityEngine.Debug.Log("�����Լ�");
    //}

    // Start is called before the first frame update
    void Start()
    {
        //Test NewTest = null;

        //NewTest.Func();

        //UnityEngine.Debug.Log("�����Լ�");

        //this�� ���� �÷��̾� ��ũ��Ʈ �� ��ü�� ���۷����̴�.

        //Transform MyTrans = GetComponent<Transform>();

        //if (null == MyTrans)
        //{
        //    Debug.Log("Ʈ�������� ����");
        //    return;
        //}

        // ���ʹ� x,y,z ��
        //MyTrans.position = new Vector3(2, 0, 0);

        //SpriteRenderer SR = GetComponent<SpriteRenderer>();

        //if(null == SR)
        //{
        //    Debug.Log("��������Ʈ �������� ����");
        //    return;
        //}

        //Status STATUS = GetComponent<Status>();

        //if(null == STATUS)
        //{
        //    Debug.Log("�������ͽ��� �����");
        //    return;
        //}

        //Debug.Log("���� ���ݷ� �������ͽ�" + STATUS.AT);
        //STATUS.AT = 5000;
        //Debug.Log("����� ���ݷ� �������ͽ�" + STATUS.AT);

        // ���� RGBA 0~0.1
        //SR.color = new Color(0.0f, 0.0f, 0.0f, 0.5f);

        //SR.flipX = true;
    }

    // Update is called once per frame
    void Update()
    {
        // <��ŸŸ��>
        // A��ǻ�ʹ� 1�ʿ� 1�� �����ϰ� B��ǻ�ʹ� 1�ʿ� 2���� �����Ѵٰ� ����.
        // ��ǻ�Ϳ��� ��¥ �ʴ� �ð��� �˾ƿ� �� �ִµ�
        // 1�ʿ� 100�̶�� ���ڸ� ������ 1�� ������ �� �� �ִٰ� ����. �׸��� �� ���� �����Ѵٰ� ����.

        //       A     B           A    B
        // 0.5         50 / 100 =      0.5
        // 0.5  100   100 / 100 =  1    1
        // 0.5        150 / 100 =      1.5
        // 0.5  200   200 / 100 =  2    2
        // 0.5        250 / 100 =      2.5
        // 0.5  300   300 / 100 =  3    3

        // ���� ���� ����ߴٰ� ���ش�.
        //       A         B               A    B
        // 0.5             50-  0 / 100 =      0.5
        // 0.5  100-0     100- 50 / 100 =  1   0.5
        // 0.5            150-100 / 100 =      0.5
        // 0.5  200-100   200-150 / 100 =  1   0.5
        // 0.5            250-200 / 100 =      0.5
        // 0.5  300-200   300-250 / 100 =  1   0.5

        // A    B   ���ǵ�   A    B (�����̵��Ÿ�)
        //     0.5 * 50   =      25
        // 1   0.5 * 50   = 50   50
        //     0.5 * 50   =      75
        // 1   0.5 * 50   = 100  100
        //     0.5 * 50   =      125
        // 1   0.5 * 50   = 150  150
        // ���⼭ 1�� 0.5�� ��ŸŸ���̴�.

        //������ �������� �� �ִ� �������� �ִ��ѵ��� update�� ���ش�
        // Debug.Log("������Ʈ");

        // ������ ����
        // 0,0,0
        //+1,0,0
        //=1,0,0
        //+1,0,0
        //=2,0,0
        // x�� x����, y�� y����, z�� z���� ���Ѵ�

        // ������ ����
        // 1,0,0 *2
        // = 2,0,0

        // transform.position += new Vector3(0.1F, 0.0F, 0.0F) * Time.deltaTime;
        transform.position += MyVector3.Right * Time.deltaTime;
    }
}
