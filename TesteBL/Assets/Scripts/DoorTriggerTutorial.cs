using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorTriggerTutorial : MonoBehaviour
{
        [SerializeField] GameObject door;
        [SerializeField] GameObject door2;

        bool isOpened = false;

        Animator doorAnimator;
        Animator door2Animator;

        private void Start()
        {
            doorAnimator = door.GetComponent<Animator>();
            door2Animator = door2.GetComponent<Animator>();
        }

        void OnTriggerEnter(Collider col)
        {
            if (isOpened == false)
            {
                isOpened = true;
                doorAnimator.Play("OpenDoor", 0, 0.0f);
                door2Animator.Play("OpenDoor2", 0, 0.0f);
            }
        }

        void OnTriggerExit(Collider col)
        {
            if (isOpened == true)
            {
                isOpened = false;
                doorAnimator.Play("CloseDoor", 0, 0.0f);
                door2Animator.Play("CloseDoor2", 0, 0.0f);
            }
        }
}
