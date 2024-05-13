using UnityEngine.InputSystem;
using UnityEngine;

public class PlayerInputController : TopDown
{
    private Camera _camera;
    protected override void Awake()
    {
        base.Awake();
        _camera = Camera.main;      //메인 카메라라는 테그가 붙어있는 카메라를 가져온다
    }

    public void OnMove(InputValue value)
    {
        // Debug.Log("OnMove" + value.ToString());
        Vector2 moveInput = value.Get<Vector2>().normalized;
        CallMoveEvent(moveInput);
        //실제 움직이는 처리는 플레이어 무브먼트에서 하게된다.
    }

    public void OnLook(InputValue value)
    {
        // Debug.Log("OnLook" + value.ToString());
        Vector2 newAim = value.Get<Vector2>();
        Vector2 worldPos = _camera.ScreenToWorldPoint(newAim);
        newAim = (worldPos - (Vector2)transform.position).normalized;

        if (newAim.magnitude >= .9f)
        // Vector 값을 실수로 변환
        {
            CallLookEvent(newAim);
        }
    }

    public void OnFire(InputValue value)
    {
        IsAttacking = value.isPressed;
    }
}