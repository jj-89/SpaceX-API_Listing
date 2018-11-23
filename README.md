# SpaceX-API_Listing
A listing of all SpaceX missions.

Technologies used: C#/ASP.NET, Json, KendoUI, Azure.

This was a very fun project for me to work on, being a huge fan of Elon Musk and SpaceX specifically. I started by researching KendoUI and
deciding to try out their services for ASP.NET MVC. I was able to get the API data and get it into my view, but using this format I was
unable to find a way to deserialize the Json array into a list of Json Objects so they could be rendered in the KenoGrid. I struggled with
this for some time before deciding to scrap what I had, and to try my hand with the JQuery KendoGrid. This was a far more effective 
approach as I did not have to do extra work on the back end to deserialize the Json array, and the syntax for the two types of grids are 
very similar. The next feature I implemented was the modal window to display the cargo manifest. I could not find any actual link to any 
official cargo manifests, so I took the relevant payload data from the API and created my own. Implementing the modal window was fairly 
straight forward. The issue I encountered here was pulling the information from the Json objects outside of the grid. When I would use the
syntax used in setting up the fields ( #= rockets.rocket_id #) it would return 'Object object'. When I would try to drill down using the 
same method ( #= rockets.second_stage.payloads.payload_id #) it would return 'undefined'. I found that I had to index which array I
needed inside of the object (#= rockets.second_stage.payloads[0].norad_id[0] #). That completed the project as far as pulling data from the
API and displaying it goes. To host the project I used Microsoft Azures free trial and published the website there. 

// PLANS FOR THE FUTURE
Cache data from the API to limit the number of calls to it. 
Implement logic that will check the cached data for the latest launch and update the DB if it is not current.
Create pages that will have general information on SpaceX, and Elons other companies (Boring, Tesla, ect...)
Create different pages for past launches and future launches.
Implement some logic that will remove the fields for 'NORAD ID' and both 'Payload Mass' fields if they hold no information. 
Play with KendoUI's custom template builder to add some flavor to the page
Implement media queries to create a more optimized view for mobile devices. 
