Feature: Turnup_Feature

A short summary of the feature

@tag1
Scenario: Login into TurnUp portal and Create Time Material record
	Given I log into TurnUp portal
	When I navigate to Time and Material page
	And I create a new Time and Material record '1' 'first description' '100'
	Then The record should be saved '1'

Scenario: Login into TurnUp portal and Edit Time Material record
	Given I log into TurnUp portal
	When I navigate to Time and Material page
	And I edit a new Time and Material record '2' 'second description' '200'
	Then The record should be saved '2'
