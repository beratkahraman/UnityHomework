using UnityEngine;
using UnityEngine.SceneManagement;

public class Barrier : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // "Barrier" tag'ine sahip obje ile temas kontrolü
        if (other.CompareTag("Barrier"))
        {
            // "lose" sahnesine geçiş
            SceneManager.LoadScene("lose");
        }
    }
}
