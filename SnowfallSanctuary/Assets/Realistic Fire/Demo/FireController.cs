using UnityEngine;

public class FireController : MonoBehaviour {

	public GameObject firePrefab;
	
	private GameObject BaseParticles;
	private GameObject FlamesParticles;
	private GameObject SparksParticles;
	private GameObject SmokeParticles;
	private GameObject FireLight;

	private bool toggleFire = true;
	private bool toggleSmoke = true;
	private bool toggleSparks = true;
	private bool toggleBase = true;
	private bool toggleLight = true;

	// Use this for initialization
	void Start () {
		BaseParticles = firePrefab.transform.FindChild("BaseParticles").gameObject;
		FlamesParticles = firePrefab.transform.FindChild("FlamesParticles").gameObject;
		SparksParticles = firePrefab.transform.FindChild("SparksParticles").gameObject;
		SmokeParticles = firePrefab.transform.FindChild("SmokeParticles").gameObject;
		FireLight = firePrefab.transform.FindChild("FireLight").gameObject;
	}

	void OnGUI() {
		toggleFire = GUI.Toggle(new Rect(10, 10, 100, 30), toggleFire, "Fire");
		FlamesParticles.SetActive(toggleFire);

		toggleSmoke = GUI.Toggle(new Rect(10, 50, 100, 30), toggleSmoke, "Smoke");
		SmokeParticles.SetActive(toggleSmoke);

		toggleSparks = GUI.Toggle(new Rect(10, 90, 100, 30), toggleSparks, "Sparks");
		SparksParticles.SetActive(toggleSparks);

		toggleBase = GUI.Toggle(new Rect(10, 130, 100, 30), toggleBase, "Base");
		BaseParticles.SetActive(toggleBase);

		toggleLight = GUI.Toggle(new Rect(10, 170, 100, 30), toggleLight, "Light");
		FireLight.SetActive(toggleLight);
	}
}
