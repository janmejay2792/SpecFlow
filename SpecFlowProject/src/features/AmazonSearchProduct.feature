Feature: AmazonSearchProduct
	In order to avoid silly mistakes
	Check the Product Availability and list the size

Scenario: Search The Product on Amazon Applicatio0n
	Given Launch The Application and Navigate to URL
	When When i search the iphone
	Then Iphone product is displayed 




Scenario Outline: Search Multiple Products on Amazon Application
	Given Launch The Application and Navigate to URL
	When Check the Products <Product> and check the details with respect
	Then Tear Down the Application
	Examples: 
	| Product |
	| IPhone  |
	| Samsung |
	| MotoRola|

