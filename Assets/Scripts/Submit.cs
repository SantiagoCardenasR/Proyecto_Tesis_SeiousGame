using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using GoogleSheetsToUnity;
public class Submit : MonoBehaviour
{
    public InputField _name;
    public InputField lastName;
    public InputField mail;
    public InputField enterprise;

    private string name_field;
    private string lastName_field;
    private string mail_field;
    private string enterprise_field;
    private List<string> list = new List<string>();
    private string associatedSheet = "1GrsTxAEOe1NIzwune7jvqwHKf6SpIp4ZrB5vsVqxwSs";
    private string associatedWorkSheet = "Data";

    void Start()
    {
        //_name = gameObject.GetComponent<InputField>();
        //lastName = gameObject.GetComponent<InputField>();
        //mail = gameObject.GetComponent<InputField>();
        //enterprise = gameObject.GetComponent<InputField>();
        name_field = "";
        lastName_field = "";
        mail_field = "";
        enterprise_field = "";
    }

    public void submit_information()
    {
        string time = System.DateTime.Now.ToString("h:mm:ss");
        list.Add(time);
        name_field = _name.text;
        print(name_field);
        lastName_field = lastName.text;
        print(lastName_field);
        mail_field = mail.text;
        print(mail_field);
        enterprise_field = enterprise.text;
        print(enterprise_field);
        list.Add(name_field);
        list.Add(lastName_field);
        list.Add(mail_field);
        list.Add(enterprise_field);
        SpreadsheetManager.Append(new GSTU_Search(associatedSheet, associatedWorkSheet), new ValueRange(list), null);
    }

}
