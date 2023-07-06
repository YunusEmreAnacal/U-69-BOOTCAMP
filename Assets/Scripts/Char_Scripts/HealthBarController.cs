using UnityEngine;
using UnityEngine.UI;

public class HealthBarController : MonoBehaviour
{
    public Slider healthSlider; 
    public FallDamage FallDamageScript; 

    // Start is called before the first frame update
    void Start()
    {
        FallDamageScript.can = 200;
        healthSlider.maxValue = FallDamageScript.can; 
        healthSlider.value = FallDamageScript.can; 
    }

    // Update is called once per frame
    void Update()
    {
        UpdateHealthBar();
    }

    void UpdateHealthBar()
    {
        if (healthSlider.value > FallDamageScript.can)
        {
            healthSlider.value = FallDamageScript.can; 
        }
        else if (healthSlider.value < FallDamageScript.can)
        {
            healthSlider.value -= Time.deltaTime * 10f; 
        }
    }
}