using UnityEngine;
using UnityEngine.SceneManagement;

public class Trap : MonoBehaviour
{ 
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(0);
        }
    }
}
