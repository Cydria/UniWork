
public class Undead {
	protected String food;
	
	public Undead(){
		
	}
	
	public Undead(String food){
		this.food = food;
	}
	
	public void setFood(String food){
		this.food = food;
	}
	
	public String getFood(){
		return this.food;
	}
	
	public void eats(){
		System.out.println("The undead eats "+ food); 
	}
	public static void main(String[] args) {
		// TODO Auto-generated method stub

	}

}
