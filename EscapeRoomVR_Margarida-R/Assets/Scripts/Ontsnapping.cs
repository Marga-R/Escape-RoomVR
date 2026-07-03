using UnityEngine;
using UnityEngine.SceneManagement; // Nodig om de scene te herladen!

public class Ontsnapping : MonoBehaviour
{
    public GameObject winMenu; // Hier slepen we het Canvas in

    void Start()
    {
        winMenu.SetActive(false); // Verberg het menu als de game start
    }

    void OnTriggerEnter(Collider andere)
    {
        // Als een object (de speler) in deze onzichtbare zone stapt
        winMenu.SetActive(true); // Laat het menu zien!
    }

    public void HerstartGame()
    {
        // Laad de huidige wereld opnieuw in
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}