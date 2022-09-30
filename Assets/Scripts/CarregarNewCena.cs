using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
using UnityEngine.SceneManagement;

public class CarregarNewCena : MonoBehaviour
{
    // Start is called before the first frame update 
    void Start(){} 

    // Update is called once per frame 
    void Update(){} 

    //Muda a Cena Atual
    public void carregaCena(string nomeCena)
    {
        SceneManager.LoadScene(nomeCena);
    } 
}
