using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformBehavior : MonoBehaviour
{
    void Update()
    {
        this.transform.Translate(Vector3.down * Time.deltaTime);        
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Platform"))
        {
            Destroy(this.gameObject);
        }
    }
}
