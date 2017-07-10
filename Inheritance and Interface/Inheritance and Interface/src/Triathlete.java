
public class Triathlete implements Swim {
	
	public void run(){
		System.out.println("run");
	}
	
	public void cycle(){
		System.out.println("cycle");
	}

	public void fastSwim(){
		System.out.println("fastSwim");
	}
	
	public void slowSwim(){
		System.out.println("slowSwim");
	}
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		Triathlete t = new Triathlete();
		t.fastSwim();
		t.slowSwim();
	}

}
