Feature: Candidate Registration
user is checking of candidate list
  Scenario Outline: Tc_01_Add a candidate with different statuses
    Given the user opens the website and logs in
    And the user navigates to add candidate page
	When the user enter "<Name>" "<ID>" "<Phone1>" "<Phone2>" "<Email>" "<Refferdby>" "<Address>" "<supportstatus>" "<startdate>" "<Amount>" "<Agreedtotalamount>" "<totalpaid>" "<Status>" "<Notes>" "<Date>" "<Signature>"
    And the user saves the candidate
    Then the candidate should be added with correct status

  Examples:
    | Name   | ID | Phone1     | Phone2     | Email               | Refferdby | Address    | supportstatus                    | startdate  | Amount | Agreedtotalamount | totalpaid | Status              | Notes                   | Date       | Signature |
    | Gudari |  1 | 8499020987 | 1234567890 | gudari.qa@gmail.com | someone   | KPHB       | No Support                       | 16-12-2025 |  30000 |            300000 |    100000 | Ready for Interview | Candidate remarks added | 16-12-2025 | gudari    |
    | Ramesh |  2 | 9998887776 | 8889997776 | ramesh@gmail.com    | someone   | Hyderabad  | Active Support (Monthly Billing) | 16-12-2025 |  30000 |            300000 |    100000 | Ready for Interview | Candidate remarks added | 16-12-2025 | ramesh    |
    | Suresh |  3 | 9876543210 | 8765432109 | suresh@gmail.com    | someone   | Kukatpally | Support Ended                    | 16-12-2025 |  30000 |            300000 |    100000 | Ready for Interview | Candidate remarks added | 16-12-2025 | suresh    |
#@SmokeTest
#Scenario Outline:Verify that user can check the training And Placement
#Given The User Open the website and logs in
#And the user navigate to Training and placement page
#When the user click on interview and Resumes
#And the user click on Schedule interview
#And the user select the candidate
#And the user select the date 
#And The user select time
#And the user enter company name
#And the user select meeting type
#And the user enter on round
#And user enter support person name
#And user click on save shedule
#Then the user should be interview sheduled succesfully