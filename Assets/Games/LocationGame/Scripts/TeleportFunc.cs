using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TeleportFunc : MonoBehaviour
{
    [System.Serializable]
    public class PosHolder
    {
        [SerializeField] private string name;
        [SerializeField] private Button pos;

        public string Name => name;
        public Button ButtonPos => pos;
    }

    public ButtonIndex[] buttonIndex;

    [SerializeField] private PosHolder[] position;
    [SerializeField] private TextMeshProUGUI headLabel;
    [SerializeField] private GameObject explosion;
    [SerializeField] private Canvas canvas;

    public void GoToLocationWithIndex(int buttonIndex)
    {
        headLabel.text = position[buttonIndex].Name;
        transform.position = position[buttonIndex].ButtonPos.transform.position;       
        Destroy(Instantiate(explosion, transform.position, Quaternion.identity, canvas.transform), 2f);
    }

}
