using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Nuevalineaescudo : MonoBehaviour
{
	public GameObject linePrefab;
	private GameObject currentLine;
	private LineRenderer lineRenderer;
	private EdgeCollider2D edgeCollider;
	private PolygonCollider2D PolygonCollider2D;
	private List<Vector2> fingerPositions = new List<Vector2>();
	public static int dibujar = 1;






	public void Update()
	{
		if (Input.GetMouseButtonDown(1))
		{
			if (dibujar==1)
			{
				CreateLine();
			}
			
		}
		if (Input.GetMouseButton(1) )
		{
			Vector2 tempFingerPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			//if (Vector2.Distance(tempFingerPos, fingerPositions[fingerPositions.Count - 1]) > 0.01f)
			{
				UpdateLine(tempFingerPos);
			}
		}
		if (Input.GetKeyDown(KeyCode.B))
        {
			StartCoroutine ("secuencia");

		}
		

	}
	IEnumerator secuencia()
	{
		yield return new WaitForSeconds(0.1f);
		BorrarEscudo();
	}

	public static void BorrarEscudo()
	{
		GameObject[] delete = GameObject.FindGameObjectsWithTag("LineEscudo");
		int deleteCount = delete.Length;
		for (int i = deleteCount - 1; i >= 0; i--)
			Destroy(delete[i]);
	}




	void CreateLine()
	{
		// Llamamos a CreateLine una sola vez cuando empezamos a dibujar para crear currentLine. currentLine se visualizará porque tendrán un lineRenderer y tendrá colisión porque tendrá un edgeCollider
		
		currentLine = Instantiate(linePrefab, Vector3.zero, Quaternion.identity);
		lineRenderer = currentLine.GetComponent<LineRenderer>();
		//PolygonCollider2D = currentLine.GetComponent<PolygonCollider2D>();
		edgeCollider = currentLine.GetComponent<EdgeCollider2D>();
		fingerPositions.Clear();
		// Como lineRenderer es una línea, necesitamos añadir dos puntos a fingerPositions para poder dibujarla sin errores
		fingerPositions.Add(Camera.main.ScreenToWorldPoint(Input.mousePosition));
		fingerPositions.Add(Camera.main.ScreenToWorldPoint(Input.mousePosition));
		lineRenderer.SetPosition(0, new Vector3(fingerPositions[0].x,fingerPositions[0] .y, 0f));
//		lineRenderer.SetPosition(1, new Vector3( fingerPositions[1].x, fingerPositions[1].y, 0f));
		//PolygonCollider2D.points = fingerPositions.ToArray();
		edgeCollider.points = fingerPositions.ToArray();
	}


	void UpdateLine(Vector2 newFingerPos)
	{
		fingerPositions.Add(newFingerPos);
		lineRenderer.positionCount=2;
		// Convertimos el List de posiciones por las que ha ido pasando el dedo en la línea que vamos a ver
		lineRenderer.SetPosition(lineRenderer.positionCount  - 1, newFingerPos);
		// Convertimos el List de posiciones por las que ha ido pasando el dedo en los puntos del edge collider
		//PolygonCollider2D.points = fingerPositions.ToArray();
		edgeCollider.points = fingerPositions.ToArray();
	}
	
}