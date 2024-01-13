using UnityEngine;

public class ZombiTakip : MonoBehaviour
{
    public Transform hedef; // Ana karakterin referansı

    public float hareketHizi = 3f; // Zombinin hareket hızı
    public float donusHizi = 5f; // Zombinin dönüş hızı

    private void Update()
    {
        TakipEt();
    }

    void TakipEt()
    {
        if (hedef == null)
        {
            Debug.LogError("Hedef belirtilmemiş!");
            return;
        }

        // Zombinin ana karakteri takip etmesi için yön hesaplanır
        Vector3 hedefYon = hedef.position - transform.position;
        hedefYon.y = 0f; // Y eksenini ihmal et (zeminde kalması için)

        // Zombinin hedefe dönmesi
        Quaternion rotasyon = Quaternion.LookRotation(hedefYon);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotasyon, donusHizi * Time.deltaTime);

        // Zombinin hedefe doğru hareket etmesi
        transform.Translate(Vector3.forward * hareketHizi * Time.deltaTime);
    }
}
