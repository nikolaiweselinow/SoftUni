using System;
//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account. Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.
class BankAccountData
{
    static void Main()
    {
        string firstName = "Nikolay";
        string middleName = "Veselinov";
        string lastName = "Vasilev";

        object holderName = firstName + " " + middleName + " " + lastName;

        decimal amountOfMoney = 2048.99m;
        string bankName = "Societe Generale Express Bank";
        string iBan = "BG234002384925";
        ulong creditCardNumber1 = 123543213561u;
        ulong creditCardNumber2 = 123543213562u;
        ulong creditCardNumber3 = 123543211653u;

        Console.WriteLine("Account holder:\t\t {0}\nAccount balance:\t {1} лв.\nBank name:\t\t {2}\nIBAN:\t\t\t {3}\nCredit card number#01:\t {4}\nCredit card number#02:\t {5}\nCredit card number#03:\t {6}", holderName, amountOfMoney, bankName, iBan, creditCardNumber1, creditCardNumber2, creditCardNumber3);

    }
}

