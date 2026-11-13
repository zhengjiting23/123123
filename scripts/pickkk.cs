using UnityEngine;

public class HoleScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // 檢查進洞的是不是球（可以透過 Tag 標籤來辨識，例如設定球的 Tag 為 "Ball"）
        if (other.gameObject.CompareTag("PickUp"))
        {
            // 方法 A：直接讓球消失（Deactivate）
            other.gameObject.SetActive(false);

            // 或者 方法 B：利用 Destroy 銷毀物件
            // Destroy(other.gameObject);
        }
    }
}