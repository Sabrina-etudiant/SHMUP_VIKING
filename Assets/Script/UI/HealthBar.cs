using UnityEngine;
using UnityEngine.UI;
public class HealthBar : MonoBehaviour
{
    public Image healthBarEnemy;
    [HideInInspector] public LifeBehavior enemy;

    private void Start()
    {
        enemy = this.gameObject.GetComponentInParent<LifeBehavior>();
    }
    public void UpdateEnemyHealthBar()
    {
        healthBarEnemy.fillAmount = Mathf.Clamp(enemy.healthAmount / enemy.maxHealth, 0, 1f);
    }
}