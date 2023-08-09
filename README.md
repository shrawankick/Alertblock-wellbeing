# Alertblock-wellbeing-
we are creating a alerts  for the users to take a beak at least 2 minutes for every one hour 

 this we are using winform apps 
this is mostly a POC 
we are targetting it for windowss user for the ball to roll 
but we can target to every os 

**here we are not going to collect any users info {PII is prohibited}
this is to just send the Alert message **


some of the reference

**https://learn.microsoft.com/en-us/windows/apps/design/shell/tiles-and-notifications/send-local-toast?tabs=uwp**

https://learn.microsoft.com/en-us/windows/apps/windows-app-sdk/notifications/app-notifications/app-notifications-quickstart?tabs=cs

https://www.c-sharpcorner.com/article/working-with-popup-notification-in-windows-forms/

___


ActiveWork Reminder: Stay Healthy, Stay Productive

Problem Statement: 
The prolonged sitting culture in our workplace has resulted in employees experiencing numerous health issues due to extended sedentary behavior. 
The lack of opportunities for standing breaks and movement during work hours contributes to physical discomfort, decreased productivity, and potential long-term health complications. 
As a result, we need to find innovative solutions to promote healthier work habits and reduce the negative impact of prolonged sitting on our employees' well-being and overall performance.



The proposed solution is to develop a application that will serve as a reminder and encourage employees to take short breaks every one hour during their workday. 
The application will send a gentle notification to the user, prompting them to stand up and look around for two minutes without interrupting their current tasks. 
This approach aims to promote movement, reduce sedentary behavior, and mitigate the health problems associated with prolonged sitting. The app's design will focus on non-intrusive messages, 
ensuring that employees stay engaged in their work while also prioritizing their well-being and overall health. By encouraging regular breaks, 
the application aims to create a healthier work environment and enhance the overall productivity and happiness of the employees.

___


 # Creating a Break Reminder Windows Forms Application


***
**Problem Statement:**
Employees facing health issues due to prolonged sitting hours; aiming to develop a Windows Forms app for timely break reminders.

**Solution Overview:**
Developing a Windows Forms application that periodically sends break reminders to promote healthier habits.
***


## Project Steps:

## Design User Interface:

1. Create UI with a label and button.
1. Drag and drop Timer control for reminders.

## Break Notification:

1. Customize break reminder messages.
1. Display notifications at regular intervals.
1. Prevent closing notifications from the taskbar.

## Customization:

1. Customize notification appearance for a modern look.
1. Add a close button after a defined interval.

## Deployment 

1. we need to create pacakage file so that user can install  
1. if we have any updates/fix we need to create updated file and Send to all the installed computer
1. we needd to make sure that app is loking for updates 

---
below can be over kill but we need try 
---

## User Activity Tracking:

Detect computer lock/unlock events.
Pause notifications during lock and resume afterward.
Implement user activity detection to validate reminders.
## Break Occurrence Tracking:

Record the number of breaks taken.
Implement a report to display break occurrences.
