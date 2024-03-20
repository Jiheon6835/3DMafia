using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform centralAxis;
    public Transform cam;
    public float camSpeed;
    public Transform playerAxis;
    public Transform player;
    public float rotSpeed;

    float mouseX;
    float mouseY;
    float wheel;

    Vector3 movement;

    void CamMove()
    {
        mouseX += Input.GetAxis("Mouse X");
        mouseY += Input.GetAxis("Mouse Y") * -1;

        centralAxis.rotation = Quaternion.Euler(
            new Vector3(
                centralAxis.rotation.x + mouseY,
                centralAxis.rotation.y + mouseX,
                0) * camSpeed);
    }

    void PlayerMove()
    {
        if (Input.GetMouseButton(1))
        {
            player.rotation = Quaternion.Euler(
                new Vector3(
                    0,
                    playerAxis.rotation.y + mouseX, 0) * rotSpeed);
        }

        else
        {
            if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.W))
            {
                player.rotation = Quaternion.Euler(
                    new Vector3(
                        0,
                        playerAxis.rotation.y + mouseX + -22.5f, 0) * rotSpeed);
            }

            else
            {
                if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.S))
                {
                    player.rotation = Quaternion.Euler(
                        new Vector3(
                            0,
                            playerAxis.rotation.y + mouseX + -67.5f, 0) * rotSpeed);
                }

                else
                {
                    if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
                    {
                        player.rotation = Quaternion.Euler(
                            new Vector3(
                                0,
                                playerAxis.rotation.y + mouseX + 67.5f, 0) * rotSpeed);
                    }

                    else
                    {
                        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
                        {
                            player.rotation = Quaternion.Euler(
                                new Vector3(
                                    0,
                                    playerAxis.rotation.y + mouseX + 22.5f, 0) * rotSpeed);
                        }

                        else
                        {
                            if (Input.GetKey(KeyCode.W))
                            {
                                player.rotation = Quaternion.Euler(
                                    new Vector3(
                                        0,
                                        playerAxis.rotation.y + mouseX, 0) * rotSpeed);
                            }

                            if (Input.GetKey(KeyCode.A))
                            {
                                player.rotation = Quaternion.Euler(
                                    new Vector3(
                                        0,
                                        playerAxis.rotation.y + mouseX + -45, 0) * rotSpeed);
                            }

                            if (Input.GetKey(KeyCode.S))
                            {
                                player.rotation = Quaternion.Euler(
                                    new Vector3(
                                        0,
                                        playerAxis.rotation.y + mouseX + 90, 0) * rotSpeed);
                            }

                            if (Input.GetKey(KeyCode.D))
                            {
                                player.rotation = Quaternion.Euler(
                                    new Vector3(
                                        0,
                                        playerAxis.rotation.y + mouseX + 45, 0) * rotSpeed);
                            }
                        }
                    }
                }
            }
        }
    }
    void Zoom()
    {
        wheel += Input.GetAxis("Mouse ScrollWheel");
        if (wheel >= -1)
            wheel = -1;
        if (wheel <= -5)
            wheel = -5;
        cam.localPosition = new Vector3(0, 1.7f, wheel + -4);
    }

    // Update is called once per frame
    void Update()
    {
        CamMove();
        Zoom();
        PlayerMove();
    }

    private void LateUpdate()
    {
        centralAxis.position = new Vector3(player.transform.position.x, 1f, player.transform.position.z);
        playerAxis.position = new Vector3(player.transform.position.x, 0f, player.transform.position.z);
    }
}