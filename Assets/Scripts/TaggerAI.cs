using UnityEngine;

public class TaggerAI : MonoBehaviour
{
    public Transform target; // �ǂ�������Ώہi�v���C���[�j
    public float speed = 3f; // �S�̈ړ����x

    void Update()
    {
        if (target != null)
        {
            // �v���C���[�ւ̕������v�Z
            Vector3 direction = (target.position - transform.position).normalized;

            // �S�̌������v���C���[�Ɍ�����
            Quaternion lookRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * speed);

            // �S��O���Ɉړ�������
            transform.position += transform.forward * speed * Time.deltaTime;
        }
    }
}
