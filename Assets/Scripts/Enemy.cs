using UnityEngine;

public class Enemy : Person_base
{
    public override void SayHi() {
        Debug.Log($"go fuck yourself!!!");
    }

    public override void Attack()
    {
        Debug.Log("as an ENEMY i do some damage to the player and to NPCs as well");
    }
}
