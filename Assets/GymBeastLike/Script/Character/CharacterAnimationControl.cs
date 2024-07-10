using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace GymBeastLike
{
    public class CharacterAnimationControl : MonoBehaviour , IAnimationController
    {
        private Animator animator;
        private string[] animations = { "Idle", "Run" };
        void Awake()
        {
            animator = GetComponent<Animator>();
        }
        public void PlayAnimationByParameter(string ani, bool play)
        {
            animator.SetBool(ani, play);
        }
    }
}
