using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCondition : MonoBehaviour
{
    public UiCondition uICondition;

    Condition HP { get {  return uICondition.HP; } }

    public float hpDecay;
    // Update is called once per frame
    void Update()
    {
        HP.Subtract(hpDecay * Time.deltaTime);

        if(HP.curValue <= 0)
        {
            Die();
        }
    }
    public void Die()
    {
        Debug.Log("Á×À½");
    }
    public void Heal(float amout)
    {
        HP.Add(amout);
    }
}
