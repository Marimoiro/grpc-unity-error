using System.Collections;
using System.Collections.Generic;
using Grpc.Core;
using Helloworld;
using UnityEngine;

public class Test : MonoBehaviour {

	// Use this for initialization
	void Start ()
	{
	    Greeter.GreeterClient client = new Greeter.GreeterClient(new Channel("localhost", 12345,ChannelCredentials.Insecure));
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
