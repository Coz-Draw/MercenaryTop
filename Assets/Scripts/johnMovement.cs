using UnityEngine;

public class johnMovement : MonoBehaviour
{
    // Nota Isaack: Velocidad del jugaor y creacion de clases de rigibdy
    public float speed = 5f;

    private Rigidbody2D rb;
    private Vector2 movement;

    // Camilo nota: referencia al animator para controlar animaciones
    private Animator animator;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // Camilo nota: obtenemos el animator del jugador
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Camilo nota: moviimineto WASD
        movement.x = Input.GetAxisRaw("Horizontal"); // A/D
        movement.y = Input.GetAxisRaw("Vertical");   // W/S

        // Camilo nota: que el movmiento sea igual en cualquier direcion 
        movement = movement.normalized;

        // Camilo nota: aqui activamos la animacion de correr si se esta moviendo
        // si movement es diferente de (0,0) entonces esta corriendo
        if (animator != null)
        {
            animator.SetBool("running", movement != Vector2.zero);
        }
    }

    void FixedUpdate()
    {
        // Camilo nota: aplicamos el movimiento fisico al rigidbody
        rb.linearVelocity = movement * speed;
    }
}