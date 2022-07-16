using UnityEngine;

public class PlayerDataHolder : MonoBehaviour
{
    [SerializeField] private PlayerData playerData;


    private void Awake()
    {
        playerData.positionValue = transform.position;
    }

    private void Start()
    {
        playerData.playerHealth = GetComponent<Health>();
    }

    private void Update()
    {
        playerData.positionValue = transform.position;
    }
}