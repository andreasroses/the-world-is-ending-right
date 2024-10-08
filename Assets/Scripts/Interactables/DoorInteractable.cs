using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteractable : MonoBehaviour, I_Interactable {

    [SerializeField] private Animator animator;
    private bool isOpen;

    private void Awake() {
        animator = GetComponent<Animator>();
    }

    public void ToggleDoor() {
        isOpen = !isOpen;
        animator.SetBool("isOpen", isOpen);
    }

    public void Interact(PlayerManager player) {
        ToggleDoor();
    }

    public string GetInteractText() {
        return "Open/Close Door";
    }

    public Transform GetTransform() {
        return transform;
    }
}