using UnityEngine;

public class TaggerAI : MonoBehaviour
{
    public Transform target; // 追いかける対象（プレイヤー）
    public float speed = 3f; // 鬼の移動速度

    void Update()
    {
        if (target != null)
        {
            // プレイヤーへの方向を計算
            Vector3 direction = (target.position - transform.position).normalized;

            // 鬼の向きをプレイヤーに向ける
            Quaternion lookRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * speed);

            // 鬼を前方に移動させる
            transform.position += transform.forward * speed * Time.deltaTime;
        }
    }
}
