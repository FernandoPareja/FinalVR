using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
public class continousMovement : MonoBehaviour
{
    public float speed = 1f;
    public XRNode inputSource;
    public GameObject rig;
    private Vector2 inputAxis;
    private CharacterController character;
    public float gravity = -9.81f;
    private float fallingSpeed;
    public LayerMask groundLayer;
    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        InputDevice device = InputDevices.GetDeviceAtXRNode(inputSource);
        device.TryGetFeatureValue(CommonUsages.primary2DAxis, out inputAxis);
    }
    private void FixedUpdate() {

        Quaternion headYaw = Quaternion.Euler(0, rig.transform.eulerAngles.y, 0);
        Vector3 diredction = headYaw * new Vector3(inputAxis.x, 0, inputAxis.y);

        character.Move(diredction * Time.fixedDeltaTime * speed);

        //gravity
        bool isGrounded = CheckIfGrounded();
        if (isGrounded){
            fallingSpeed = 0;
        }
        else
            fallingSpeed += gravity * Time.fixedDeltaTime;

        character.Move(Vector3.up * fallingSpeed * Time.deltaTime);
    }

    bool CheckIfGrounded(){
        Vector3 rayStart = transform.TransformPoint(character.center);
        float rayLength = character.center.y + 0.01f;
        bool hasHit = Physics.SphereCast(rayStart, character.radius, Vector3.down, out RaycastHit hitInfo, rayLength, groundLayer);
        return hasHit;
    }
}
