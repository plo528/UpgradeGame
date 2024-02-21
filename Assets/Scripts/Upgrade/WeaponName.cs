using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponName : MonoBehaviour
{

    public string[] weaponName = new string[40] {"조잡한 나무검", "낡은 연습용검", "낡은 대검", "롱소드", "하피날개 검", "스피어 소드", "뼈갈퀴 검", "기사단의 검", 
        "스켈레톤 군단검", "핫뜨검", "피바라기", "룬 소드", "용암 대검", "창공의 날개", "다크 디멘션", "태양의 군주", "인페르노 소드", "빙하기", "테라 소드", "잊혀진 검", 
        "분해된 마검", "할로우 소드", "드루이드의 명예", "레인탈 소드", "유성검", "레바테인", "달타냥의 레이피어", "기사단장의 검", "뇌룡의 뿔", "라운드홀 소드", "유클리드 소드", 
        "창공의 파괴자", "진정한 피바라기", "진정한 인페르노", "일각룡의 뿔", "마모된 마신검", "칼파고스 검", "본스틸러", "엑스칼리버", "그람" };

    public string ChangeName(int val)
    {
        return name = weaponName[val];
    }
}
