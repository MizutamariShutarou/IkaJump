using UnityEngine;

[CreateAssetMenu(fileName = "PlayerParameter", menuName = "ScriptableObjects/Parameter/PlayerParameter")]
public class PlayerParamator : ScriptableObject
{
    [SerializeField, Tooltip("ジャンプ力")]
    private float _jampPower = 0f;

    [SerializeField, Tooltip("左右の移動速度")]
    private float _horizontalSpeed = 0f;
}
