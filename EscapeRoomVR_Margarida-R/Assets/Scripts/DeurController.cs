using UnityEngine;

public class DeurController : MonoBehaviour
{
    public void OpenDeur()
    {
        // 1. Zoek de AudioSource op deze deur en speel het geluid af!
        GetComponent<AudioSource>().Play();

        // 2. We kunnen de deur nu niet direct "Destroyen", 
        // want dan stopt het geluid ook meteen! 
        // We maken hem in plaats daarvan onzichtbaar en ontastbaar:
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<BoxCollider>().enabled = false;

        Debug.Log("Deur is geopend met geluid!");
    }
}