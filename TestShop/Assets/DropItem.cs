using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropItem : MonoBehaviour
{
    [SerializeField]
    private ItemObject itemObject;
    private float rotateSpeed;

    private void Start()
    {
        rotateSpeed = Random.Range(25, 50);
    }

    private void OnTriggerEnter(Collider other)
    {
        var player = other.GetComponent<Player>();
        if (player != null)
        {
            player.AddItemToInventory(itemObject);
            Destroy(gameObject);
        }
    }

    private void Update()
    {
        int rndDir = (rotateSpeed % 2 == 0) ? 1 : -1;
        transform.Rotate(Vector3.up*rotateSpeed*rndDir*Time.deltaTime);
    }
}
