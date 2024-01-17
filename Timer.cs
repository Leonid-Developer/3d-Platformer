using UnityEngine;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
    public float second = 59;
    public int minute = 4;

    void Update()
    {
        second -= Time.deltaTime;

        if(second <= 0)
        {
            if (minute <= 0)
            {
                SceneManager.LoadScene(0);
            }
            else
            {
                minute--;
                second = 59;
            }
        }
    }
}
