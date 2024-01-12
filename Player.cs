using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    //�������� ������

    private int health = 10;

    //
    public GameObject fireballPrefab;
    public Transform attackPoint;

    public void TakeDamge(int damage)
    {
        health -= damage;

        print("�������� ������: " + health);
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
}
