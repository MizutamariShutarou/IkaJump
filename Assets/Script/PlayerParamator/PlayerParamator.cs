using UnityEngine;

[CreateAssetMenu(fileName = "PlayerParameter", menuName = "ScriptableObjects/Parameter/PlayerParameter")]
public class PlayerParamator : ScriptableObject
{
    [SerializeField, Tooltip("�W�����v��")]
    private float _jampPower = 0f;

    [SerializeField, Tooltip("���E�̈ړ����x")]
    private float _horizontalSpeed = 0f;
}
