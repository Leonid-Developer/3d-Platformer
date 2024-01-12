using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    public int coin;

    public int health = 10;

    public GameObject fireballPrefab;
    public Transform attackPoint;

    public void TakeDamge(int damage)
    {
        health -= damage;
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }

        if (health <= 0)
        {
            SceneManager.LoadScene(0);
        }
    }

    public void CollectCoins()
    {
        coin++;
    }
}
