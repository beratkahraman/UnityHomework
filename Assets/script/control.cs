using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float speed = 5f; // Karakterin hareket hızı
    private float rotationSpeed = 200f; // Yön değiştirme hızı
    public float jumpForce = 7f; // Zıplama kuvveti
    private bool isGrounded = true; // Yerde mi kontrolü

    void Update()
    {
        // Yatay (sağ/sol) giriş alınması
        float horizontalInput = Input.GetAxis("Horizontal");

        // Karakterin yönünü değiştirme
        transform.Rotate(Vector3.up * horizontalInput * rotationSpeed * Time.deltaTime);

        // Karakteri ileri doğru hareket ettirme
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        // Zıplama kontrolü
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            Jump();
        }
    }

    void Jump()
    {
        // Zıplama kuvveti uygula
        GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce, ForceMode.Impulse);

        // Zıplama sırasında yerde değil
        isGrounded = false;
    }

    // Yerde mi kontrolü
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }
    }
}