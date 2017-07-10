
public abstract class SerialPublication {
	public enum Frequency {DAILY, WEEKLY, MONTHLY, QUARTERLY, YEARLY, UNDEFINED};
	protected Frequency frequency;
	
	public SerialPublication(){
		this.frequency = Frequency.UNDEFINED;
	}
	
	public SerialPublication(String freq){
		setFrequency(freq);
	}
	
	public void setFrequency(String freq){
		try{
			this.frequency = Frequency.valueOf(freq.toUpperCase());
		}
		catch (IllegalArgumentException e){
			this.frequency = Frequency.UNDEFINED;
		}
	}
	
	public String getFrequency(){
		return this.frequency.toString().toLowerCase();
	}
	
}
