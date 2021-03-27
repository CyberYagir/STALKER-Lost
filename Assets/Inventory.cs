using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {
    public float RifleBullets;
    public float PistolBullets;
    public float Stamina = 100;
    public float MaxStamina = 100;

    public float Hunger = 0;
    public float MaxHunger = 100;

    public float Health = 100;
    public float MaxHealth = 100;

    public int Money = 0;

    public GameObject DeadText;

    public bool Conserva;
    public bool Aptechka;
    public bool Antiradin;
    public bool Dinamite;
    public bool Artifact;
    public bool Voter;
    void FixedUpdate()
    {
        StaminaFunc();
        HungerFunc();
        HealthFunc();
        Dead();
    }
    void StaminaFunc()
    {
        if (Stamina < 0)
        {
            Stamina = 0;
        }
        if (Stamina > MaxStamina)
        {
            Stamina = MaxStamina;
        }
        Stamina += 0.025f;
    }
    void HungerFunc()
    {
        if (Hunger < 0)
        {
            Hunger = 0;
        }
        if (Hunger >= 99)
        {
            Hunger = MaxHunger;
        }
        Hunger += 0.005f/1.5f;
    }
    void HealthFunc()
    {
        if (Health < 0)
        {
            Health = 0;
        }
        if (Health > MaxHealth)
        {
            Health = MaxHealth;
        }
    }
    void Dead()
    {
        if (Health <= 0)
        {
            DeadText.SetActive(true);
            transform.GetComponent<PlayerController>().enabled = false;
            StartCoroutine(Wait());
        }
    }
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2);
        Application.LoadLevel("Manu");
    }
}
