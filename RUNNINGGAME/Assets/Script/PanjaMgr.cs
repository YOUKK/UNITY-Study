using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanjaMgr : MonoBehaviour
{
    [SerializeField]
    Sprite PanjaSprite = null;

    // ���� �ð����� ���ڰ� ��������� �ϴ� ��
    // 0.5�ʸ��� ���ڰ� ��������� �Ѵ�
    
    [SerializeField]
    private float CreateRandomRangeYStart = -2.0f;
    [SerializeField]
    private float CreateRandomRangeYEnd = 2.0f;

    [SerializeField]
    private float CreateRandomScaleXStart = 5.0f;
    [SerializeField]
    private float CreateRandomScaleXEnd = 10.0f;

    [SerializeField]
    private float CreateRandomInterXStart = 2.0f;
    [SerializeField]
    private float CreateRandomInterXEnd = 4.0f;

    [SerializeField]
    private float CreateRange = 20.0f;

    [SerializeField]
    private float LastCreatePosX = 0.0f;

    [SerializeField]
    private float LastCreateScaleX = 0.0f;

    void NewPanjaLogic()
    {
        GameObject NewPanja = new GameObject("Panja");
        NewPanja.transform.localScale = new Vector3(UnityEngine.Random.Range(CreateRandomScaleXStart, CreateRandomScaleXEnd), 1.0f, 1.0f);

        Vector3 CreatePos = new Vector3();

        CreatePos.x = LastCreateScaleX + LastCreatePosX + (NewPanja.transform.localScale.x * 0.5F);
        CreatePos.x += CreateRandomInterXStart + Random.Range(CreateRandomScaleXStart, CreateRandomScaleXEnd)
        CreatePos.y = UnityEngine.Random.Range(CreateRandomRangeYStart, CreateRandomRangeYEnd);
        CreatePos.z = 0.0f;
        // z�� 0���� ����� ���ڰ� ī�޶��� ��ġ�� ������ �ʰ� �տ� ����
        // CreatePos.y -= 2.0f;

        NewPanja.transform.position = CreatePos;
        
        // AddComponent<Ŭ������>
        // NewPanja.AddComponent<SpriteRenderer>(); //�տ� this.����. ���� ��������� ���� ��������Ʈ������
        SpriteRenderer NewSp = NewPanja.AddComponent<SpriteRenderer>();
        NewSp.sprite = PanjaSprite;

        LastCreatePosX = CreatePos.x;
        LastCreateScaleX = NewPanja.transform.localScale.x * 0.5F;

        //Debug.Log("CreatePos : " + CreatePos);
        //Debug.Log("NewPanja.transform.localScale : " + NewPanja.transform.position);
    }

    void Start()
    {
        for(int i = 0; i < 2; i++)
        {
            NewPanjaLogic();
        }
    }

    // Update is called once per frame
    void Update()
    {
        

        // 0.0���ٴ� ������ ����� ���� �ȴ�.
        // �ֳĸ� ��ŸŸ���� ���� ��Ȯ�� �� ���� �����̴�.(��ġ�� ����ȭ�߱� ����)
        // CreateTime -= Time.deltaTime;
    }
}
