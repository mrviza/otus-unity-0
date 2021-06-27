using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimationEvents : MonoBehaviour
{
    Character character;

    void Start()
    {
        character = GetComponentInParent<Character>();
    }

    void ShootEnd()
    {
        character.KillEnemy();
        character.SetState(Character.State.Idle);
    }

    void BecameDead()
    {
        character.SetState(Character.State.Dead);
    }

    void AttackEnd()
    {
        character.KillEnemy();
        character.SetState(Character.State.RunningFromEnemy);
    }
}
