
public class Zombie extends Undead {
	public static int numberOfZombies;
	
	public Zombie(){
		numberOfZombies++;
	}
	
	public Zombie(String food){
		this.food = food;
		numberOfZombies++;
	}
	
	public void eats(){
		System.out.println("Zombie eats " + food);
	}
	public static void main(String[] args) {
		// TODO Auto-generated method stub

	}

}
