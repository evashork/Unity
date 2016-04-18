void Shot(){
		foreach(GameObject boxIn in boxList){  // foreach (찾을 데이터 타입과 임시 이름 in 배열이나 리스트)
			boxIn.gameObject.SetActive(true);
			randomX = Random.Range (-150, 150);
			randomY = Random.Range (300, 600);
			randomZ = Random.Range (-150, 150);
			boxIn.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(randomX, randomY, randomZ));
	}
}
