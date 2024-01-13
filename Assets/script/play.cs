using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    // Bu fonksiyon Play butonuna tıklandığında çağrılır
    public void OnPlayButtonClicked()
    {
        // "GameScene" adındaki sahneye geçiş yap
        SceneManager.LoadScene("map1");
    }
}
