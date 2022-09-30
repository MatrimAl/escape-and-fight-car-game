using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class damageManager : MonoBehaviour
{
    Collider2D m_Collider;
    
    [SerializeField] private int enemyDamage;
    [SerializeField] private HealthManager _healthController;
    [SerializeField] Transform spawnPoint;
    void Start()
    {
        m_Collider = GetComponent<Collider2D>();
        
    }
    private void OnTriggerEnter2D(Collider2D enemy)
    {
        if (enemy.tag == "Rocket")
        {
            Damage();
            transform.position = spawnPoint.position;

        }
        else if (enemy.tag == "Enemy")
        {
            Damage();
            transform.position = spawnPoint.position;

        }
        StartCoroutine(carTouch());
    }
    void Damage()
    {
        _healthController.playerHealth = _healthController.playerHealth - enemyDamage;
        _healthController.UpdateHealth();
        
     
    }
    IEnumerator carTouch()
    {
        
        m_Collider.enabled = false;
        
        yield return new WaitForSeconds(3);
        m_Collider.enabled = true;
    }
}
