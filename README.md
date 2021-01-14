Superhero Speed Networking
==========================

[Speed networking](https://en.wikipedia.org/wiki/Speed_networking) basically involves participants gathering together to exchange information. Participants greet each other in a series of brief exchanges during a set period of time. During an interaction, participants share their professional backgrounds and business goals. Networkers are generally seeking exposure to new markets and/or expanding their pool of vendors.  

We've gathered 20 superheroes who are looking to attend our speed networking event.  We've asked them to pick up to 4 other heros that they would like to meet with during this event and rank them according to how much they want to meet with them (1 = High, 4 = Low).  

## Speed Networking Rules:

* 4 time slots
* 2 heros to a table
* Each hero must meet with 4 other heros
* Before the event starts, each hero will have picked between 0-5 other heros that they prefer to meet with
  * A rank of 1 means high interest
  * A rank of 5 means low interest
  * Unranked means they are indifferent
* A hero can only meet with one other hero during a given time slot

# Objective

* Run the project which will load up "First Superhero Networking Event"
* Underneath the event name, adjust the event date to show the time of the event in this format (h:mm tt [windows abbreviated timezone])
	- The result should look like this: Mon Nov 16 2020 9:00 AM PST
* Fix the bug with Side not populating in the Heroes table
* Adjust the preferences columns to show the following:
	- If Preference count = 0, then show a warning message that the user did not select any preferences.
	- If Preference count > 0, then show the list of hero names with their rank
* You'll notice that the Add Hero button launches a Create Hero modal/form and that if you click on a record, you're prompted with a edit hero form.
	- Create the form with the following validation rules:
		- Name and Side are mandatory and Side should be a dropdown
		- Preferences => can have a minimum of 0 and a max of 5
	- Wire the Save button to call HeroesController.Save
	- Complete the code in HeroesController.Save to create/update hero (feel free to use inmemory cache/static list or write to the json file)
* Add the ability to delete a hero from the interface.  
	- On the UI, add ability to delete a hero (your discretion on implementation)
	- Wire the delete button to call HeroesController.Delete
	- In HeroesController.Delete, complete the code.
* Create a new component, sh.hero.list.js, that shows the same information but as a list versus a table (sh.hero.table.js)
	- See https://getbootstrap.com/docs/4.0/components/list-group/
	- Make sure the same functionality (update/delete) works in the list
* Write the Match algorithm.
	- In Javascript, wire the Create Meetings button on the Meetings tab to make the call to /api/Events/Match
	- In C#, write your algorithm to generate and save the Meetings[] in EventModel.
	- Adhere to the above rules and maximize meetings based on preferences:
	  - Rank 1 = 50 pts
	  - Rank 2 = 25 pts
	  - Rank 3 = 10 pts
	  - Rank 4 = 5 pts
	  - Rank 5 = 1 pt
	  - No preference = 0 pts
* Fix XSS errors
	- Change your url to https://localhost:44303/Home/Index/Sample-Event
	- Without changing Events.json, fix the code so that the "Fix me" alerts do not get triggered
* Bonus points
	- Show your results on the Meetings tab
	- As the browser width changes, switch from the table view to a list view when the browser width < 600px and vice versa
	- Add a toggle (somewhere) to allow a user to view the event & meetings in their local timezone
	- Swap out the Meetings tab with FullCalendar (import js libs)
		- Add a toggle to view schedule by hero
		- Add a toggle to view schedule by timezone
	- On each meeting, add a button (Add to Calendar) that downloads an ics file so that you can add it to your calendar
	- Add a dropdown in the menu that lets you toggle between all the events in Events.json
	- Add a form that lets you create/update events
	- Add front end ui test(s) and/or back end test(s) in any testing framework

# Submission

* Please download this solution and use it to build out your project.  Please use Git to save your commits. When finished, please send us a .ZIP file of your solution.
* Please don't leave any publicly available copies of this project online. Do not use our company name anywhere in the project.
* Your solution must compile, and the application must be runnable.
* Your solution should work correctly in Chrome (> 79.0.3945)
* You must use jQuery and a utility library like Lodash, but not larger frameworks like React, Angular or Vue.js.
* You must document your assumptions and solution in file called SOLUTION.md. Please note how many hours was spent within the SOLUTION.md file.
* Feel free to bring in any third party code.
* Feel free to make any adjustments to existing classes if necessary.
