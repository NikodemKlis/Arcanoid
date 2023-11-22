using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ui : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI tmp;
    public float fontSizeModifier = 1f;

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.A))
        {
            tmp.fontStyle = FontStyles.Bold;
            tmp.text = "GIGANIGSON";
            tmp.color = Color.blue;
            tmp.fontStyle = FontStyles.Italic;
        }
    }
}
