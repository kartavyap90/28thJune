Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowProject1/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
Scenario: Add two numbers
	Given First number for addition is 50
	And Second number for addition is 70
	When the two numbers are added
	Then Result for addition should be 120

Scenario: Sub two number
	Given First number for Subtraction is 30
	And Second number for Subtraction is 20
	When the two number are subtracted
	Then Result for subtraction should be 10

Scenario: Mul two number
	Given First number for Multiplication operation is 4
	And Second number for Multiplication operation is 5
	When the two number are multiply
	Then Result for multiplication should be 20

Scenario: Div two number
	Given First number for Division operation is 80
	And Second number for Division operation is 2
	When the two number are divided
	Then Result for division should be 40

