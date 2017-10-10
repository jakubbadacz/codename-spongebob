using UnityEngine;
using UnityEngine.UI;

public class NavView : MonoBehaviour {

	public Text positionXText, positionYText;
	public Text speedText;
	public Button forwardBtn, backBtn, leftBtn, rightBtn;
    //public GameObject display;

	private NavController navController;
	private NavModel navModel;
	void Awake()
	{
		navController = GetComponent<NavController>();
	}

	void Start () 
	{
		forwardBtn.onClick.AddListener (ForwardClicked);
		backBtn.onClick.AddListener (BackClicked);
		leftBtn.onClick.AddListener (LeftClicked);
		rightBtn.onClick.AddListener (RightClicked);
		navModel = navController.GetNavModel();

        //float xPos = navModel.GetPositionX();
        //float yPos = navModel.GetPositionY();

        //for(int i=0; i < 10; i++)
       // {
           // Button temp = Instantiate(gridButt, new Vector3(i+(-111.9F), 34.2F, 0), Quaternion.identity);
            //temp.transform.SetParent(display.transform);
        //}


        UpdateViews();
	}

	void Update () 
	{
		UpdateViews();
	}

	private void UpdateViews()
	{
		positionXText.text = navModel.GetPositionX()+",";
		positionYText.text = navModel.GetPositionY () + "";
		speedText.text = navModel.GetVelocity ()+"";

	}

	void ForwardClicked(){
		navController.Forward ();
	}
	void BackClicked(){
		navController.Backwards ();
	}
	void LeftClicked(){
		navController.Left ();
	}
	void RightClicked(){
		navController.Right ();
	}
}
