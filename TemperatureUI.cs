using UnityEngine;
using TMPro;

public class TemperatureUI : MonoBehaviour
{
    public Temperature temperature_cs;

    public TextMeshProUGUI temperatureText;

    private float temperature;

    private void Update()
    {
        temperature = Mathf.Round(temperature_cs.temperatureCurrent * 10.0f) * 0.1f;

        temperatureText.text = temperature.ToString();
    }
}
