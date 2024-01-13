using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // Çarpışan objenin "light" tag'ına sahip olup olmadığını kontrol et
        if (collision.gameObject.CompareTag("Light"))
        {
            // Çarpışan objeyi yok et
            Destroy(collision.gameObject);
        }
    }
}
