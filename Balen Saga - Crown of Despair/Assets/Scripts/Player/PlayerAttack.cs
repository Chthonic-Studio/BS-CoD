using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour
{
    private RaycastHit2D[] hits;
    [SerializeField] private Transform attackTransform;
    [SerializeField] private float attackRange = 1.5f;
    [SerializeField] private LayerMask attackableLayer;
    [SerializeField] private float damageAmount = 1f;
    [SerializeField] private float timeBtwAttacks = 0.15f;

    private Animator anim;

    private float attackTimeCounter;
    public bool ShouldBeDamaging { get; set; } = false;
    private List<iDamageable> iDamageables = new List<iDamageable>();
    

    private void Start()
    {
        anim = GetComponent<Animator>();
        attackTimeCounter = timeBtwAttacks;
    }

    private void Update()
    {
        if (UserInput.instance == null)
        {
        Debug.LogError("UserInput instance is null");
        }
        else if (UserInput.instance.controls == null)
        {
        Debug.LogError("UserInput controls is null");
        }
        else if(UserInput.instance.controls.Attack.slashDown.WasPressedThisFrame() && attackTimeCounter >= timeBtwAttacks)
        {
            //reset counter
            attackTimeCounter = 0f;
            
            //attack
            //Attack();
            anim.SetTrigger("slashDown");
        }

        attackTimeCounter += Time.deltaTime;
    }

/*
    private void Attack()
    {
        hits = Physics2D.CircleCastAll(attackTransform.position, attackRange, transform.right, 0f, attackableLayer);

        for (int i = 0; i < hits.Length; i++)
        {
            iDamageable iDamageable = hits[i].collider.GetComponent<iDamageable>();

            //If the object is damageable, damage it

            if (iDamageable != null)
            {
                iDamageable.Damage(1f);
            }
        }
    
    }
*/

    public IEnumerator DamageWhileSlashIsActive()
    {
        ShouldBeDamaging = true;
        
        while (ShouldBeDamaging)
        {
            hits = Physics2D.CircleCastAll(attackTransform.position, attackRange, transform.right, 0f, attackableLayer);

            for (int i = 0; i < hits.Length; i++)
            {
                iDamageable iDamageable = hits[i].collider.GetComponent<iDamageable>();

                //If the object is damageable, damage it

                if (iDamageable != null && iDamageable.HasTakenDamage == false)
                {
                    iDamageable.Damage(damageAmount);
                    iDamageables.Add(iDamageable);
                }
            } 
        
            yield return null;   

        }

        ReturnAttackableToNormal();
    }

    private void ReturnAttackableToNormal()
    {
        foreach (iDamageable thingThatWasDamaged in iDamageables)
        {
            thingThatWasDamaged.HasTakenDamage = false;
        }

        iDamageables.Clear();
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(attackTransform.position, attackRange);
    }

    #region Animation Triggers

    public void ShouldBeDamagingToTrue()
    {
        ShouldBeDamaging = true;
    }

    public void ShouldBeDamagingToFalse()
    {
        ShouldBeDamaging = false;
    }

    #endregion
}
 