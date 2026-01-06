Feature: Featurefileofchatgpt
@Regression

   Scenario Outline: Tc_01 Verify user can save Ledgeraccount record
  Given user navigate to login page
  When user clicks Finance module
  And user click on Legder Accounts
  And user click Add Account
  And user fills details with "<Name>" "<Accounttype>" "<subledger>" "<openingbalence>" "<Fixedmonthlyamount>" "<startdate>" "<Description>"
  And user click on save account
  Then Accounts added succesfully

Examples:
  | Name   | Accounttype | subledger | openingbalence | Fixedmonthlyamount | startdate  | Description              |
  | Ajay   | Bank        | sbi       |          50000 |                  0 | 16-12-2025 | Personal savings account |
  | ram    | Cash        | hdfc      |         100000 |                  0 | 16-12-2025 | Business current account |
  | kalyan | Debtor      | icici     |          30000 |                  0 | 16-12-2025 | Monthly salary account   |
  | mahesh | Creditor    | bajaj     |          20000 |                  0 | 16-12-2025 | Office expense account   |
  | veeru  | Expense     | indus     |          20000 |               5000 | 17-12-2025 | loan account             |
  | Rohit  | Salary      | canara    |          80000 |               7000 | 16-12-2025 | Monthly salary account   |
  | sachin | Income      | kotak     |          60000 |                  0 | 17-12-2025 | Freelance income account |
  | Rahul  | Equity      | yesbank   |          40000 |                  0 | 16-12-2025 | Investment account       |
 @Regression

  Scenario Outline:Tc_02 Verify user can save <Module> record
    Given user navigate to login page
    When user clicks Finance module
    And user click on Payroll
	And user clicks payexpance module
    And user selects <Module> page
    And user fills details with "<Date>" "<Amount>" "<From>" "<To>" "<Description>"
    Then record should be saved successfully


  Examples:
    | Module   | Date       | Amount | From        | To             | Description         |
    | Income   | 16-12-2025 |  10000 | Gudari (1)  | Ajay [Bank]    | Advance payment     |
    | Expense  | 16-12-2025 |  15000 | Ajay [Bank] | Rohit [Salary] | Stationary purchase |
    | Transfer | 16-12-2025 |  20000 | Ajay [Bank] | ram [Cash]     | Salary transfer     |
    | Refund   | 16-12-2025 |  50000 | ram [Cash]  | Gudari (1)     | Refund to candidate |


 @Regression

 
 Scenario Outline:Tc_03 Verify user can check on  Transactions save or Not
    Given user navigate to login page
    When user clicks Finance module
    And user click on Transactions
	And user fill details with "<Description>" "<Types>" "<Statuses>" "<SourceFrom>" "<DestinationTo>" "<Fromdate>" "<Todate>"


  Examples:
    | Description         | Types    | Statuses | SourceFrom | DestinationTo  | Fromdate   | Todate     |
    | Advance payment     | Income   | Unlocked | Gudari (1) | Ajay           | 16-12-2025 | 16-12-2025 |
    | Stationary purchase | Expense  | Unlocked | Ajay       | Rohit [Salary] | 16-12-2025 | 16-12-2025 |
    | Salary transfer     | Transfer | Unlocked | ram        | Ajay           | 16-12-2025 | 16-12-2025 |
    | Refund to candidate | Refund   | Unlocked | ram        | Gudari (1)     | 16-12-2025 | 16-12-2025 |

   @Regression

    Scenario Outline:Tc_04 Verify user can check on  LedgerAccounts
    Given user navigate to login page
    When user clicks Finance module
    And user click on Legder Accounts
    Then user search by name or sub-type "<Searchby>" 

    Examples:
    | Searchby |
    | Ajay     |
    | ram      |
    | kalyan   |
    | mahesh   |
    | veeru    |
    | Rohit    |
    | sachin   |
    | Rahul    |
