using UnityEngine;

//Nota Isaack: Scricp para que la camara sigua siempre al jugador
public class CameraFollow : MonoBehaviour
{
    public Transform target; // el jugador
    public float smoothSpeed = 5f;

    void LateUpdate()
    {
        if (target == null) return;

        Vector3 desiredPosition = new Vector3(
            target.position.x,
            target.position.y,
            transform.position.z // a pesar de que ya anilamos el eje z en el juego igual ponemos esta parte para que siempre tenga en gaunta al jugador nota Isaack
        );

        transform.position = Vector3.Lerp(
            transform.position,
            desiredPosition,
            smoothSpeed * Time.deltaTime
        );
    }
}