using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LoginWarning : MonoBehaviour
{
    public TMP_InputField Username;
    public TMP_InputField Password;
    

    public GameObject[] canvas;

    public void CheckValidation()
    {
        string u_name = Username.text;
        string pass = Password.text;

        if(u_name == "ibokocal53" && pass == "kocal53123")
        {
            Debug.Log("Giriş Başarılı & Login Successfully");       
        }
        else if (u_name == "" || pass == "")
        {
            Debug.Log("Eksik veya hatalı giriş yaptınız. Tekrar Deneyiniz");
        } 
        else
        {
            Debug.Log("Lütfen Doğru Kullanıcı Adı ve Şifreyi Giriniz && Please Enter Correct Username and Password");
        }
    }

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Entere basılarak login yapma işlemi çalıştı");
            CheckValidation();
        }
    }
}
