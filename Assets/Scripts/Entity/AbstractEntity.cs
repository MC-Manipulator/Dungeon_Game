using UnityEngine;

public abstract class AbstractEntity : MonoBehaviour
{
    public EntityType entityType;   // 实体类型
    public float currentHealth;     // 当前健康值
    public float maxHealth;         // 最大健康值
    public float attack;            // 攻击力
    public float defence;           // 防御力
    public float speed = 5;         // 当前速度
    private float initialSpeed;     // 初始速度
    public Vector2 mapPosition;     // 地图坐标
    public float attackRange;       // 攻击范围

    protected abstract float Damage();
    protected abstract void Die();
    public abstract float Hurt(float damage);
    protected abstract void Action();
    public void PerformAction()
    {
        Debug.Log($"{name} 正在执行行动...");
        Action();
    }

    public abstract float GetActionSpeedCost();

    public abstract void Attack(AbstractEntity target);

    private void Awake()
    {
        // 在 Awake 中记录初始速度
        initialSpeed = speed;
    }
    public void ResetSpeed()
    {
        speed = initialSpeed;
        Debug.Log($"{name} 的速度重置为初始值: {initialSpeed}");
    }

    public enum EntityType
    {
        Explorer, // 探险者
        Monster,  // 怪物
        Trap      // 陷阱
    }

}
