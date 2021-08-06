Feature: PAPR
	Simple calculator for adding two numbers

@login
Scenario Outline: Open Respiratory website and make login into it
	Given Open the PAPR website
	And Click on the signin button
	When Enter the emailid<emailid> and password<password>
	Then Provide the generated OTP and make login into application

	@source:data.xlsx:sheet1
	Examples:
		| emailid | password |


@SearchResultsforSearchByCategory
Scenario Outline: Select any Respiratory Category and show the results
	Given Open the PAPR websites
	And Click on the siggnin button
	When Enter the emilid<emailid> and password<password>
	Then Provide the gnerated OTP and make login into application
	Then Select any Respiratory category and get the results
	@source:data.xlsx:sheet1
	Examples:
		| emailid | password |


@logout
Scenario Outline: Open Respiratory Website make login into application then Logout from application
	Given Open the PAPR website in Dev
	And Click on the signin button present there.
	When Provdide the emilid<emailid> and password<password>
	Then Enter the gnerated OTP and make login into application
	Then make logout from the application and close the browser.
	@source:data.xlsx:sheet1
	Examples:
		| emailid | password |

@FilterbyAttributes
Scenario Outline: Select any Respiratory Category and verify FIlter by attributes.
	Given Open the PAPR website application
	And Click on the signin button there
	When Enter the emailid<emailid> and passwoord<password>
	Then Provide the gnerted OTP and make login into application
	Then Select any Respiratory category and verify filter by attributes.
	@source:data.xlsx:sheet1
	Examples:
		| emailid | password |