using UnityEngine;
using System.Collections.Generic;

public class CharacterStatHandler : MonoBehaviour
{
    // 기본 스탯과 버프 스탯들의 능력치를 종합해서 스탯을 계산하는 컴포넌트
    [SerializeField] private CharacterStat baseStats;
    public CharacterStat CurrentStat { get; private set; }
    public List<CharacterStat> statsModifiers = new List<CharacterStat>();      //추가스탯 저장소

    private void Awake()
    {
        UpdateCharacterStat();      //처음에 기본능력치를 저장하는것
    }

    private void UpdateCharacterStat()
    {
        // statModifier를 반영하기 위해 baseStat을 먼저 받아옴
        AttackSO attackSO = null;
        if (baseStats.attackSO != null)
        {
            attackSO = Instantiate(baseStats.attackSO);     //Instantiate를 하면 서로 다른 두개가 된다. Instantiate를 사용하지 않으면 똑같은것 하나를 만드는것이다
        }

        CurrentStat = new CharacterStat { attackSO = attackSO };
        // TODO : 지금은 기본 능력치만 적용되고 있지만, 향후 능력치 강화 기능등이 추가될 것임!
        CurrentStat.statsChangeType = baseStats.statsChangeType;        //기본세팅
        CurrentStat.maxHealth = baseStats.maxHealth;
        CurrentStat.speed = baseStats.speed;

    }
}