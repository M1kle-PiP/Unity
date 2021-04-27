using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimaT : MonoBehaviour
{   
    public Vector3 startPosition; // Object start position
    public Vector3 targetPosition; // Target position
    public float time = 0; // Something like progress
    public float sec = 35; // Time taken for an object to travel a given distance

    void Update()
    {
    	transform.position = Vector3.Lerp(startPosition, targetPosition, easeInQuart(time/sec)); // Here put an curve formul 
    	time += Time.deltaTime;
	// We move the object from the start position to target position using a curve for time. And accelerate object by adding deltaTime every frame.
    }

    // Different time curves. You can see they visualization on site.

    float easeInQuad(float x)
    {
    	return x*x;
    	//https://easings.net/en#easeInQuad
    }

    float easeInCubic(float x)
    {
    	return x*x*x;
    	//https://easings.net/en#easeInCubic
    }

    float easeInQuart(float x)
    {
    	return x*x*x*x;
    	//https://easings.net/en#easeInQuart
    } 
    // Other curve formuls you can see on a site: https://easings.net/
}

