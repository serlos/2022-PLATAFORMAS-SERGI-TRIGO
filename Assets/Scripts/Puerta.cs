using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puerta : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    [ContextMenu(itemName:"Open")] //para poder abrir la puerta desde Unity manualmente sin usar el animator
    public void Open()
    {
        animator.SetTrigger(name: "Open");
    }
}
