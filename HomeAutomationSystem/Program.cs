// See https://aka.ms/new-console-template for more information

var homeAutomation = new HomeAutomationSystem.HomeAutomationSystem();

homeAutomation.TurnOffAlarm();
homeAutomation.TurnOnLight();
homeAutomation.TurnOnMusic();
homeAutomation.TurnOnAirConditioning();

homeAutomation.TurnOffAirConditioning();
homeAutomation.TurnOffMusic();
homeAutomation.TurnOffLight();
homeAutomation.TurnOnAlarm();


