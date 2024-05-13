using UnityEngine;

[CreateAssetMenu(fileName = "RangedAttackSO", menuName = "TopDownController/Attacks/Ranged", order = 1)]
public class RangedAttackSO : AttackSO
{
    // 원거리 공격에만 있는 옵션 정의
    [Header("Ranged Attack Data")]
    public string bulletNameTag;    
    public float duration;          //얼마큼 시간동안 나가는지
    public float spread;            //랜덤으로 얼마나 퍼질지
    public int numberofProjectilesPerShot;      //한번나갈때 몇개씩 나가는지
    public float multipleProjectilesAngel;      //몇도만큼 떨어져있는지
    public Color projectileColor;   //색깔
}