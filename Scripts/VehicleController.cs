using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VehicleController : MonoBehaviour
{
    public static VehicleController instance;
    public Rigidbody2D FTire;
    public Rigidbody2D BTire;
    public Rigidbody2D vehicle;
    public float speed;
    public float movement;
    public float fuel = 1f;
    public float fuelConsumption = 0.1f;
    public Image fuelImage;
    public GameObject deathScreen;

    public void Awake() {
        if(instance == null) {
            instance = this;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Update() {
        movement = Input.GetAxis("Horizontal");
        fuelImage.fillAmount = fuel;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        if(fuel > 0) {
            FTire.AddTorque(-movement * speed * Time.fixedDeltaTime);
            BTire.AddTorque(-movement * speed * Time.fixedDeltaTime);
            vehicle.AddTorque(-movement * speed * Time.fixedDeltaTime);
        }

        fuel = fuel - fuelConsumption * Time.fixedDeltaTime * Mathf.Abs(movement);

        if(fuel <= 0) {
            LoadEndScreen();
        }
    }

    // private void checkStatus() {

    // }

    public void LoadEndScreen() {
        SceneManager.LoadScene("DeathMenu");
    }
}
