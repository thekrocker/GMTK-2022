using _Project.Scripts;
using _Project.Scripts.Utils;
using UnityEngine;

public class BulletPoolManager : MonoBehaviour
{
    public static BulletPoolManager Instance;
    public ObjectPooling<PoolObject> BulletPool;
    [SerializeField] private EnemyBullet enemyBullet;
    [field: SerializeField] public Transform EnemyBulletParent { get; private set; }

    private void Awake()
    {
        if (Instance == null) Instance = this;
    }

    void Start()
    {
        BulletPool = new ObjectPooling<PoolObject>(enemyBullet.gameObject, OnPull, OnPush, 5);
    }


    private void OnPush(PoolObject obj)
    {
        obj.GetComponent<EnemyBullet>().ResetVelocity();
    }

    private void OnPull(PoolObject obj)
    {
        obj.GetComponent<EnemyBullet>().InvokePush();
    }
}