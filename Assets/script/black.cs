using UnityEngine;
using UnityEngine.SceneManagement;

public class Black : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // "black" tag'ine sahip obje ile temas kontrolü
        if (other.CompareTag("black"))
        {
            // "map2" sahnesine geçiş
            SceneManager.LoadScene("map2");
        }
    }
}
