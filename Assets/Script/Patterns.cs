using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class Patterns : MonoBehaviour
{
    private void Start()
    {
        this.transform.DOMoveX(2f, 5f).SetLoops(-1,LoopType.Yoyo);
    }
}
 