using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="newEnemy", menuName = "New Enemy")]
public class EnemyPatterns : ScriptableObject
{
    public EnemyPattern enemyPattern;
    public GameObject enemyPrefab;
    public Vector2 spawnPoint;
    public float patternDuration;
}

public enum EnemyPattern
{
    MIN,
    DURITOS,
    FLAMING_DURITOS,
    CHEETOS,
    FLAMING_CHEETOS,
    POPCORN,
    PRETZELS,
    SALTED_PRETZELS,
    GOLDFISH_CRACKERS,
    SCHOOL_GFC,
    MAX,
}
