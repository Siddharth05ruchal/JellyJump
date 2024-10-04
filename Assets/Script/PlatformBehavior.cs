using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBehavior : MonoBehaviour
{
    public float platformMoveSpeed = 2.0f;
    void Update()
    {
        if (GameManager.Instance.startGame)
        {
            this.transform.Translate(Vector3.down * Time.deltaTime * platformMoveSpeed);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            Destroy(this.gameObject);
        }
    }
}
