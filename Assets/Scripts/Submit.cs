using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Google;

public class Submit : MonoBehaviour
{
    public InputField name;
    public InputField lastName;
    public InputField mail;
    public InputField enterprise;

    private string name_field;
    private string lastName_field;
    private string mail_field;
    private string enterprise_field;

    [SerializeField]
    private string base_url = "https://docs.google.com/forms/u/1/d/e/1FAIpQLScAKF4_F5JJYYKBTGAuRL5LnVCDvk8xotNbgdgedH0sSgVRcA/formResponse";

    IEnumerator Post(string name, string lastName, string mail, string enterprise)
    {
        WWWForm form = new WWWForm();
        form.AddField("entry.66907701", name);
        form.AddField("entry.1735751982", lastName);
        form.AddField("entry.1124099430", mail);
        form.AddField("entry.1645218451", enterprise);

        byte[] rawData = form.data;

        WWW www = new WWW(base_url, rawData);
        yield return www;
    }

    public void submit_information()
    {
        string name_field = name.text;
        string lastName_field = lastName.text;
        string mail_field = mail.text;
        string enterprise_field = enterprise.text;

        StartCoroutine(Post(name_field, lastName_field, mail_field, enterprise_field));
    }

}
