using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NameManager : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI nameText;
    [SerializeField] GameObject errorBox;
    [SerializeField] GameObject nameUICanvas;
    [SerializeField] GameObject mainUICanvas;
    [SerializeField] GameObject nameInput;

    public void SetShopName() {
        string inputText = nameInput.GetComponent<TMP_InputField>().text;
        if (inputText == "" || inputText == null) {
            // Debug.Log(OUHG);
            // errorText.text = "Invalid shop name";
            errorBox.SetActive(true);
            StartCoroutine(ShowErrorText());
            return;
        }
        nameText.text = inputText;
        Destroy(nameUICanvas);
        mainUICanvas.SetActive(true);
        Destroy(this);
    }

    IEnumerator ShowErrorText() {
        while (true) {
            // Wait for an amount of time
            yield return new WaitForSeconds(7);
            errorBox.SetActive(false);
        }
    }
}
