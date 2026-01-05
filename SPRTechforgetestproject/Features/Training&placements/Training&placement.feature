Feature: Training&placement

A short summary of the feature


Scenario Outline: Tc_01 verify that user can training&placements
	 Given user navigate to log page
     When user click on Training&placement
	And user clicks Interview&Resumes
	And the user uploads resume for "<CandidateName>"
    And the user clicks book interview for "<CandidateName>"
	And user fill with details "<date>" "<Time>" "<Companyname>" "<Type>" "<Round>" "<supportperson>"
	 Then interview should be booked successfully for
	Examples:
	| CandidateName | date       | Time    | Companyname | Type   | Round | supportperson |
	| Suresh        | 23-12-2025 | 12.30PM | ABC Pvt Ltd | Zoom | HR    | Thirumala     |
	| Ramesh        | 23-12-2025 | 02.30PM | XYZ Pvt Ltd | Teams | Tech  | Gudari       |
