using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField]
    private UIManger ui_manger;

    public List<EnemyPatterns> enemies = new List<EnemyPatterns>();
}
