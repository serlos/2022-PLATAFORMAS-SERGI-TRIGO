using System.Collections;
using System.Collections.Generic;
using System.Net.Http.Headers;
using UnityEngine;

public class LifeController : MonoBehaviour
{
    public int lifes_current;
    public int lifes_max;
    public float invencible_time;
    bool invencible;
    public GameObject[] corazones;

    public enum DeathMode { Teleport, ReloadScene, Destroy}
    public DeathMode death_mode;
    public Transform respawn;

    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();   
        lifes_current = lifes_max;
       

    }

    void Update()
    

    {
        if (transform.position.y < -12)
        {
            Death();
        }
    }

    public void Damage(int damage = 1, bool ignoreInvencible = false)
    {
        if(!invencible || ignoreInvencible)
        {
            lifes_current -= damage;
            UpdateHearts();
            StartCoroutine(Invencible_Corutine());
            if(lifes_current <= 0)
            {
                Death();
            }
        }
    }
    public void Death()
    {
        Debug.Log("He muerto");
        switch (death_mode)
        {
            case DeathMode.Teleport:
                rb.velocity = new Vector2(0, 0);
                transform.position = respawn.position;
                lifes_current = lifes_max;
                UpdateHearts();
                break;
            case DeathMode.ReloadScene:

                break;
            case DeathMode.Destroy:
                Destroy(gameObject);
                break;
            default:
                break;
        }

    }
    IEnumerator Invencible_Corutine()
    {
        invencible = true;
        yield return new WaitForSeconds(invencible_time);
        invencible = false;
    }
    private void UpdateHearts()
    {
        for (int i = 0; i < corazones.Length; i++)
        {
            if (i < lifes_current)
            {
                corazones[i].SetActive(true);
            }
            else
            {
                corazones[i].SetActive(false);
            }
        }


    }
}
