using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuKontrol : MonoBehaviour
{
    // Menü sahnesinin adını buradan ayarlayabilirsiniz
    public string menuSahnesiAdi = "menu";

    void Update()
    {
        // Escape tuşuna basıldığında menü sahnesine geçiş yapılır
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            MenüyeGec();
        }
    }

    void MenüyeGec()
    {
        // SceneManager.LoadScene ile menü sahnesine geçiş yapılır
        SceneManager.LoadScene(menuSahnesiAdi);
    }
}
