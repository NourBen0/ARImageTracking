using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragonController : MonoBehaviour
{
    [SerializeField] private float speed = 5f; // Valeur par défaut

    private FixedJoystick fixedJoystick;
    private Rigidbody rigidBody;

    private void OnEnable()
    {
        fixedJoystick = FindObjectOfType<FixedJoystick>();
        rigidBody = GetComponent<Rigidbody>(); // ✅ Correction casse : Rigidbody (pas "rigidBody")
    }

    private void FixedUpdate()
    {
        float xVal = fixedJoystick.Horizontal;
        float yVal = fixedJoystick.Vertical;

        Vector3 movement = new Vector3(xVal, 0, yVal);
        rigidBody.velocity = movement * speed;

        if (xVal != 0 || yVal != 0) // ✅ Changer && en || sinon il ne tournera pas si un seul axe est actif
        {
            float angle = Mathf.Atan2(xVal, yVal) * Mathf.Rad2Deg;
            transform.eulerAngles = new Vector3(
                transform.eulerAngles.x,
                angle,
                transform.eulerAngles.z
            );
        }
    }
}
