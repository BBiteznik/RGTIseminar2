using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PogledMiska : MonoBehaviour
{
    [System.Flags]
    public enum RotationDirection {
        None,
        Horizontal = (1 << 0),
        Vertical = (1 << 1)
    }

    [SerializeField]
    private RotationDirection rotationDirections;

    [SerializeField]
    private Vector2 acceleration;

    [SerializeField]
    private Vector2 sensitivity;

    [SerializeField]
    private float maxVericalAngleFromHorizon;

    [SerializeField]
    private float inputLagPeriod;

    private Vector2 velocity;
    private Vector2 rotation;
    private Vector2 lastInputEvent;
    private float inputLagTimer;

    private float ClampVerticalAngle(float angle) {
        return Mathf.Clamp(angle, -maxVericalAngleFromHorizon, maxVericalAngleFromHorizon);
    }

    private void OnEnable() {
        velocity = Vector2.zero;
        inputLagTimer = 0;
        lastInputEvent = Vector2.zero;

        Vector3 euler = transform.localEulerAngles;

        if(euler.x >= 180) {
            euler.x -= 360;
        }
        euler.x = ClampVerticalAngle(euler.x);
        transform.localEulerAngles = euler;
        rotation = new Vector2(euler.y, euler.x);
    }


    private Vector2 GetInput()
    {
        inputLagTimer += Time.deltaTime;

        Vector2 input = new Vector2(
            Input.GetAxis("Mouse X"),
            Input.GetAxis("Mouse Y")
        );

        if(!(Mathf.Approximately(0, input.x) && Mathf.Approximately(0, input.y)) || inputLagTimer >= inputLagPeriod) {
            lastInputEvent = input;
            inputLagTimer = 0;
        }

        return lastInputEvent;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 wantedVelocity = GetInput() * sensitivity;

        if ((rotationDirections & RotationDirection.Horizontal) == 0) {
            wantedVelocity.x = 0;
        }
        if((rotationDirections & RotationDirection.Vertical) == 0) {
            wantedVelocity.y = 0;
        }

        velocity = new Vector2(
            Mathf.MoveTowards(velocity.x, wantedVelocity.x, acceleration.x * Time.deltaTime),
            Mathf.MoveTowards(velocity.y, wantedVelocity.y, acceleration.y * Time.deltaTime)
        );

        rotation += velocity * Time.deltaTime;
        rotation.y = ClampVerticalAngle(rotation.y);

        transform.localEulerAngles = new Vector3(rotation.y, rotation.x, 0);
    }
}
