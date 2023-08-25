using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public float smoothTime = 0.3f;
    private Vector3 velocity = Vector3.zero;

    private void FixedUpdate()
    {
        if (player != null)
        {
            // Cria um novo vetor de posição com as coordenadas x e z do jogador e o valor y atual da câmera
            Vector3 targetPosition = new Vector3(player.position.x, transform.position.y, player.position.z);

            // Suaviza o movimento da câmera em direção à nova posição
            transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
        }
    }
}