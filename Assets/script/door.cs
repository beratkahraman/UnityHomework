using UnityEngine;
using UnityEngine.SceneManagement;

public class door : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // "door" tag'ine sahip obje ile temas kontrolü
        if (other.CompareTag("door"))
        {
            // "map2boss" sahnesine geçiş
            SceneManager.LoadScene("map2boss");
        }
    }
}
