using System;
using _Project.Scriptable_Objects.Scripts;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private PlayerStats stats;

    public PlayerInputMap PlayerControls;

    private Camera _cam;
    private Vector2 _moveVector;
    private CharacterController _charController;

    private void Awake()
    {
        SetReferences();
    }

    private void SetReferences()
    {
        PlayerControls = new PlayerInputMap();
        _charController = GetComponent<CharacterController>();
        _cam = Camera.main;
    }

    private void OnEnable()
    {
        PlayerControls.Enable();
    }

    private void OnDisable()
    {
        PlayerControls.Disable();
    }
    
    private void Update()
    {
        Move();
        Rotate();
    }

    private void Move()
    {
        SetMovement();
        _charController.Move(GetMovementVector());
    }

    private void Rotate()
    {
        var hit = GetRayHit();
        var targetPoint = hit.point;
        targetPoint.y = transform.position.y;
        transform.LookAt(targetPoint);
    }

    private void SetMovement()
    {
        _moveVector = PlayerControls.Player.Movement.ReadValue<Vector2>();
    }

    private Vector3 GetMovementVector()
    {
        return new Vector3(_moveVector.x * stats.moveSpeed, 0f, _moveVector.y * stats.moveSpeed) * Time.deltaTime;
    }

    private Vector2 GetMousePosition()
    {
        return PlayerControls.Player.MousePosition.ReadValue<Vector2>();
    }

    private RaycastHit GetRayHit()
    {
        Ray ray = _cam.ScreenPointToRay(GetMousePosition());
        Physics.Raycast(ray, out RaycastHit hit, Mathf.Infinity);
        return hit;
    }
}