using UnityEngine;
public class Trampoline : MonoBehaviour
{
    public Jump player_sc;

    private void OnTriggerEnter(Collider other)
    {
        player_sc.jumpStrength = 10;
    }
    private void OnTriggerExit(Collider other)
    {
        player_sc.jumpStrength = 3;
    }
}
