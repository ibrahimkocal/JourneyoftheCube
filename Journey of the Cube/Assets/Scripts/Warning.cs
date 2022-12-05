using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Warning : MonoBehaviour
{
    public TMP_InputField Username;
    public TMP_InputField Password;
    
    public TextMeshProUGUI text;
    public Button registerButton;

    public geciciscript girisyapildi;

    public GameObject[] canvas;

    public void CheckValidation()
    {
        string[] user = DatabaseConnection.GetAccount();

        string u_name = Username.text;
        string pass = Password.text;

        if(u_name == user[0] && pass == user[1])
        {
            Debug.Log("Giriş Başarılı & Login Successfully");   
            text.text = "Giriş Başarılı & Login Successfully";
            text.color = Color.green;   
            girisyapildi.isinlan();
        }
        else if (string.IsNullOrWhiteSpace(u_name) || string.IsNullOrWhiteSpace(pass))
        {
            Debug.Log("Eksik veya hatalı giriş yaptınız. Tekrar Deneyiniz & Try Again");
            text.text = "Eksik veya hatalı giriş yaptınız.\n Tekrar Deneyiniz & Try Again";
        } 
        else
        {
            Debug.Log("Lütfen doğru kullanıcı adı ve şifreyi giriniz && Please enter correct username and password");
            text.text = "Lütfen doğru kullanıcı adı ve şifreyi giriniz && Please enter correct username and password";
        }
    }


    public void Register()
    {   
        string u_name = Username.text;
        string pass = Password.text;

        if(string.IsNullOrWhiteSpace(u_name) || string.IsNullOrWhiteSpace(pass))
        {
            RegisterMouseClick();
        }
        else
        {
            Debug.Log("Kayıt işlemi gerçekleştirilemedi.");   
            text.text = "Kayıt işlemi gerçekleştirilemedi."; 
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

    public void RegisterMouseClick()
    {   
        string u_name = Username.text;
        string pass = Password.text;

        if(!string.IsNullOrWhiteSpace(u_name) || !string.IsNullOrWhiteSpace(pass))
        {
            DatabaseConnection.AddAccount(u_name,pass);
            Debug.Log("Kayıt Başarılı & Register Successfully");   
            text.color = Color.green;
            text.text = "Kayıt Başarılı & Register Successfully"; 
        }
    }
}
