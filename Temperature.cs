using UnityEngine;
public class Temperature : MonoBehaviour
{
    public Health health;

    public int playerDamage;

    public float temperatureCurrent = 36.6f;
    public float temperatureNormal = 36.6f;
    public float temperatureCritical = 34;

    public float speedFreezing;

    public float Timer = 1;
    public float Delay = 2;

    private void Update()
    {
       if(temperatureCurrent >= 34)
       {
            temperatureCurrent -= speedFreezing * Time.deltaTime;
       }

        if(temperatureCurrent <= temperatureCritical)
        {
            if(Timer <= 0)
            {
                health.TakeDamge(playerDamage);

                Timer += Delay;
            }
            else
            {
                Timer -= 0.1f * Time.deltaTime;
            }
        }
    }
}
