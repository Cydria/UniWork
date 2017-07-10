public class Newspaper extends SerialPublication {
	//Enumerable type for Newspaper class
	private enum Format {BROADSHEET, TABLOID, UNDEFINED};
	
	//Variable declaration
	private Format format;
	private String name;
	
	// Constructor
	public Newspaper(String name){
		super();
		this.name = name;
	}
	
	public Newspaper(String name, String freq){
		super(freq);
		this.name = name;
	}
	
	public Newspaper(String name, String freq, String fmat){
		super(freq);
		this.name = name;
		setFormat(fmat);

	}
	
	public void setFormat(String fmat){
		try {
			this.format = Format.valueOf(fmat.toUpperCase());
		}
		catch (IllegalArgumentException e){
			this.format = Format.UNDEFINED;
		}
	}
	
	public String getFormat(){
		return format.toString().toLowerCase();
	}
	
	public String toString(){
		String message = null;
		if (frequency == Frequency.UNDEFINED){
			message = (name + " is a newspaper published with " + frequency.toString().toLowerCase() + " frequency in " + format + " format");
		}
		else if (frequency != Frequency.UNDEFINED){
			message = (name + " is a " + frequency.toString().toLowerCase() + " newspaper in " + format.toString().toLowerCase() + " format");
		}
		return message;
	}
	
	public static void main(String[] args) {
		// TODO Auto-generated method stub

	}

}
