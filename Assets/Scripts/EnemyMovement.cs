using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 2f;
    private Transform player;

    void Start()
    {
        GameObject p = GameObject.FindGameObjectWithTag("Player");

        if (p != null)
            player = p.transform;
    }

    void Update()
    {
        if (player == null) return;

        Vector2 direction = (player.position - transform.position).normalized;
        transform.position += (Vector3)direction * speed * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            // Isaack nota: activa animación de muerte del jugador
            Animator anim = collision.gameObject.GetComponent<Animator>();

            if (anim != null)
            {
                anim.SetTrigger("Die");
            }

            // Isaack nota: desactiva movimiento del jugador (opcional pero recomendado)
            collision.gameObject.GetComponent<Rigidbody2D>().linearVelocity = Vector2.zero;

            // Isaack nota: espera un momento y luego pierde
            Invoke("LoseGame", 1f);
        }
    }

    void LoseGame()
    {
        FindObjectOfType<GameSimple>().Lose();
    }
}