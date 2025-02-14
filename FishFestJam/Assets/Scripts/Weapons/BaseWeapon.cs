using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class BaseWeapon : MonoBehaviour
{
    public float AttackSpeed;
    public float BaseDamage;
    public float WeaponMultiplier;
    public float AttackSize;

    // Run at the end of awake
    protected void InitiliazationTest() {
        if(BaseDamage <= 0)
         {
            Debug.LogError($"{this.name} does {BaseDamage} dmg");
         }
         if(AttackSpeed <= 0)
         {
            Debug.LogError($"{this.name} has {AttackSpeed} atk spd");
         }
         if(AttackSize <= 0)
         {
            Debug.LogError($"{this.name} has {AttackSize} atk size");
         }
         if(WeaponMultiplier <= 0)
         {
            Debug.LogError($"{this.name} has {WeaponMultiplier} weapon multiplier");
         }
    }
    abstract public void Attack();

    abstract public void StopAttack();

    abstract public void ToggleAttack();
}
