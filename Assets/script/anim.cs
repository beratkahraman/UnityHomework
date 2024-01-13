using UnityEngine;

public class anim : MonoBehaviour
{
    private Animator animator;
    private bool canJump = true;

    private void Start()
    {
        animator = GetComponent<Animator>();

        // Null kontrolü ekleyelim.
        if (animator == null)
        {
            Debug.LogError("Animator component not found!");
        }
    }

    private void Update()
    {
        // Null kontrolü ekleyelim.
        if (animator != null)
        {
            if (Input.GetKeyDown(KeyCode.Space) && canJump)
            {
                animator.SetTrigger("jump");
                canJump = false; // Zıplama başladığında tekrar zıplamayı engelle.
                Invoke("EnableJump", 1.9f); // 2.4 saniye sonra EnableJump metodu çağrılacak.
            }
        }
        else
        {
            Debug.LogWarning("Animator is null. Make sure to assign the Animator component in the Inspector.");
        }
    }

    // 2.4 saniye sonra bu metot çağrılacak.
    private void EnableJump()
    {
        canJump = true; // Zıplama yapıldıktan sonra bir sonraki zıplamaya izin ver.
    }
}
