Feature: AmazonSearchProduct
	In order to avoid silly mistakes
	Check the Product Availability and list the size

@mytag
Scenario: Search The Product on Amazon Applicatio0n
	Given Launch The Application and Navigate to URL
	#And Check the Title page and put all the links in list
	When Check the Title page and put all the links in list
	Then click on product and Retrieve the Price of Product


Scenario Outline: Search Multiple Products on Amazon Application
	Given Launch The Application and Navigate to URL
	When Check the Products <Product> and check the details with respect
	Then Tear Down the Application
	Examples: 
	| Product |
	| IPhone  |
	| Samsung |
	| MotoRola|
