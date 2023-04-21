using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Archer
{

    public class Enemy : MonoBehaviour, IScoreProvider
    {

        // Cu�ntas vidas tiene el enemigo
        [SerializeField]
        private int hitPoints;
        public GameObject light;

        private Animator animator;

        public event IScoreProvider.ScoreAddedHandler OnScoreAdded;

        private void Awake()
        {
            animator = GetComponent<Animator>();
        }

        // M�todo que se llamar� cuando el enemigo reciba un impacto
        public void Hit()
        {
            animator.SetTrigger("Hit");
            hitPoints--;

            if(hitPoints<=0)
            {
                Die();
            }
        }

        private void Die()
        {
            StartCoroutine(ToDie());
        }

        private IEnumerator ToDie()
        {
            print("WRYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYYY");
            animator.SetTrigger("Die");
            //light.GetComponent<LightControl>().active = true;
            light.GetComponent<Light>().intensity = 1;

            yield return new WaitForSeconds(1.3f);


           Destroy(this);

        }
    }

}