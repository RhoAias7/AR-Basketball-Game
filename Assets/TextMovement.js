#pragma strict

var textSpeed = 2.0;
var timer = 0.0;

function Start () 
{

}

function Update () 
{
	timer += Time.deltaTime;
	transform.Translate(Vector3(0, textSpeed * Time.deltaTime, 0));
	transform.localScale += Vector3(Time.deltaTime, Time.deltaTime, Time.deltaTime);
	if(timer > 2.0)
	{
	Destroy(gameObject);
	}
}