using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // "Ship" tag'ine sahip obje ile temas kontrolü
        if (other.CompareTag("Ship"))
        {
            // "win" sahnesine geçiş
            SceneManager.LoadScene("final");
        }
    }
}
