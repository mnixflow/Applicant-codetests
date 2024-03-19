namespace HomeAutomationSystem;

// ER DER NOGLE DESIGNPRINCIPPER SOM DENNE KLASSE BRYDER?
// F.EKS. SOLID PRINCIPPERNE?
// HVILKE? OG HVAD KAN MAN GØRE FOR AT LØSE DEM?

public class HomeAutomationSystem
{
    public HomeAutomationSystem()
    {
        
    }
    
    //Lighting
    public void TurnOnLight()
    {
        Console.WriteLine("Turning on light");
    }
    
    public void TurnOffLight()
    {
        Console.WriteLine("Turning off light");
    }
    
    //Air conditioning
    public void TurnOnAirConditioning()
    {
        Console.WriteLine("Turning on air conditioning");
    }
    
    public void TurnOffAirConditioning()
    {
        Console.WriteLine("Turning off air conditioning");
    }
    
    //Security
    public void TurnOnAlarm()
    {
        Console.WriteLine("Turning on alarm");
    }
    
    public void TurnOffAlarm()
    {
        Console.WriteLine("Turning off alarm");
    }
    
    
    //Music 
    public void TurnOnMusic()
    {
        Console.WriteLine("Turning on music");
    }
    
    public void TurnOffMusic()
    {
        Console.WriteLine("Turning off music");
    }
}