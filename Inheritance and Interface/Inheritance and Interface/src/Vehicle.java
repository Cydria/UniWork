
public enum Vehicle {
	CAR ("2 litres", "4 passengers"),
	VAN ("4 litres", "7 passengers"),
	BUS ("12.5 litres", "29 passengers");
	
	private String engineSize;
	private String capacity;
	
	Vehicle (String engineSize, String capacity){
		this.engineSize = engineSize;
		this.capacity = capacity;
	}
	
	public String getEngineSize(){
		return this.engineSize;
	}
	
	public String getCapacity(){
		return this.capacity;
	}
	
	public static void main(String[] args) {
		Vehicle vehicle = Vehicle.valueOf("BUS");
		System.out.println("A "+ vehicle.name().toLowerCase() + 
		" with the engine size of " + vehicle.getEngineSize() +
		" can carry " + vehicle.getCapacity());
	}
}
