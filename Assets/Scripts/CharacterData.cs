using System.Security.Cryptography.X509Certificates;
using UnityEngine;

[CreateAssetMenu(fileName = "CharacterData", menuName = "Scriptable Objects/CharacterData")]
public class CharacterData : ScriptableObject
{
    public string charaterName;
    public float maxHealth;
    public AttackData[] attacks;
}

[System.Serializable]

public class AttackData
{
    public string AttackName;
    public float minDamage;
    public float maxDamage;
    public string animationName;
    public GameObject attackParticles;
    public GameObject attackHitParticles;

    
}