using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanjaMgr : MonoBehaviour
{
    [SerializeField]
    Sprite PanjaSprite = null;

    // 일정 시간마다 판자가 만들어지게 하는 법
    // 0.5초마다 판자가 만들어지게 한다
    
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
        // z를 0으로 해줘야 판자가 카메라의 위치에 생기지 않고 앞에 생김
        // CreatePos.y -= 2.0f;

        NewPanja.transform.position = CreatePos;
        
        // AddComponent<클래스명>
        // NewPanja.AddComponent<SpriteRenderer>(); //앞에 this.생략. 새로 만들어지는 것의 스프라이트렌더러
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
        

        // 0.0보다는 작지만 가까운 값이 된다.
        // 왜냐면 델타타임은 절대 정확할 수 없기 때문이다.(수치를 간략화했기 때문)
        // CreateTime -= Time.deltaTime;
    }
}
