using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    public float speed;
    public GameObject gunPrefab;
    Vector3 dirVelocity;

    void Update()
    {
        Vector3 position = Input.mousePosition;
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(new Vector3(position.x, position.y, Camera.main.transform.position.y));
        Vector3 dir = mousePos - transform.position;

        dir.y = 0f;

        transform.rotation = Quaternion.LookRotation(dir, Vector3.up);
    }

}

