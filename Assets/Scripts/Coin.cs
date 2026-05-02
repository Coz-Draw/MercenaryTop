using UnityEngine;

public class Coin : MonoBehaviour
{
    public bool isGold;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerCoins pc = other.GetComponent<PlayerCoins>();

            if (isGold)
                pc.AddGold();
            else
                pc.AddCopper();

            Destroy(gameObject);
        }
    }
}