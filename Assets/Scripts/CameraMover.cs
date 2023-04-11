using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMover : MonoBehaviour
{

    public float my_angle;
    public float my_angle_y;

    public Transform my_camera;

    public float rotation_prop;
    public float mouse_x_position;
    public float max_rotation;

    public float half_rotation;

    public float rotation_prop_y;
    public float mouse_y_position;
    public float max_rotation_y;
    public float half_rotation_y;

    public float bound;
    public float bound_y;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
    }

    // Update is called once per frame
    void Update()
    {
        mouse_x_position = Input.mousePosition.x;
        mouse_y_position = Input.mousePosition.y;

        if (mouse_x_position > bound)
        {
            mouse_x_position = bound;
        }
        if (mouse_y_position > bound_y)
        {
            mouse_y_position = bound_y;
        }

        rotation_prop = mouse_x_position / max_rotation;
        rotation_prop -= 0.5f;
        my_angle = rotation_prop * half_rotation;

        rotation_prop_y = mouse_y_position / max_rotation_y;
        rotation_prop_y -= 0.5f;
        my_angle_y = rotation_prop_y * half_rotation_y;

        my_angle_y = my_angle_y * -1f;
        my_angle_y += 10f;

        my_camera.localRotation = Quaternion.Euler(my_angle_y,my_angle,0f);

    }
}
