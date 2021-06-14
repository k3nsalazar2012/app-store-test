using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class OpenLink : MonoBehaviour
{
    [SerializeField] private TMP_InputField url;

    public void OpenInAppStore() => Application.OpenURL(url.text);
}
