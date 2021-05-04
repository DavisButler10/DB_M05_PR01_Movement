using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour
{
    public GameObject player;

    void Update()
    {
        transform.position = new Vector3(0.33f, player.transform.position.y, 3.5f);
    }
}
