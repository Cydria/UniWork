
public class VariableArity {
	
	public static void printInt(int ... params){
		int counter = 0;
	    for (int i: params){
	        System.out.print(i);
	        counter++;
	        if (counter != params.length){
	        	System.out.print(" ");
	        }
	    }
	}
	        
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		System.out.print("*");
		printInt(3, 6, 7, 2, 4, 5, 9, 5, 6, 8, 7);
		System.out.print("*");
	}

}
