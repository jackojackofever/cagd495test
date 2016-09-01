using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HBAR : MonoBehaviour {

    public Scrollbar Healthbar;
    public float health;

	public void damage(float value)
    {

        health -= value;
        Healthbar.size = health / 100f;
    }
	
}
