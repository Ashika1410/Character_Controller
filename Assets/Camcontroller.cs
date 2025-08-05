using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camcontroller : MonoBehaviour
{
    public float RotationSpeed = 1;
    CharacterController controller;
    public Transform Target, Player;
    float mouseX, mouseY;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    private void LateUpdate()
    {
        Camcontrol();
    }
    public void Camcontrol()
    {
        mouseX += Input.GetAxis("Mouse X") * RotationSpeed;
        mouseY -= Input.GetAxis("Mouse Y") * RotationSpeed;
        mouseY = Mathf.Clamp(mouseY, -1, 7);
        transform.LookAt(Target);
        Target.rotation = Quaternion.Euler(mouseY, mouseX, 0);
        Player.rotation = Quaternion.Euler(mouseY, mouseX, 0);

    }

}
