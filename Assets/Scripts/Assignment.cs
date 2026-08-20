using UnityEngine;

public class Assignment : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //As01_CheckNumberSign();
        //As02_GetDayName();
        //As03_ValidatePassword();
        //As04_GetGrade();
        //As05_IsLeapYear();
        //As06_Calculate();
        //As07_GetSeason();
        //As08_PurchasingSystemExample();
        //As09_RockPaperScissorsExample();
        //As10_CalculateWeaponDamage();
        //As11_DeterminePlayerRank();
    }

    public int as01Number;
    public void As01_CheckNumberSign()
    {
        // TODO: Implement logic to determine sign
        // Example: Debug.Log("Positive");
        if (as01Number > 0)
        {
            Debug.Log("Positive");
        }
        else if (as01Number < 0)
        {
            Debug.Log("Negative");
        }
        else
        {
            Debug.Log("Zero");
        }
    }

    public int as02Day;
    public void As02_GetDayName()
    {
        switch (as02Day)
        {
            case 1:
                Debug.Log("Monday");
                break;

            case 2:
                Debug.Log("Tuesday");
                break;

            case 3:
                Debug.Log("Wednesday");
                break;

            case 4:
                Debug.Log("Thursday");
                break;

            case 5:
                Debug.Log("Friday");
                break;

            case 6:
                Debug.Log("Saturday");
                break;

            case 7:
                Debug.Log("Sunday");
                break;

            default:
                Debug.Log("Invalid day");
                break;
        }
    }

    public string as03InputPassword;
    public string as03CorrectPassword;
    public void As03_ValidatePassword()
    {
        if (as03InputPassword == as03CorrectPassword)
        {
            Debug.Log("True");
        }
        else
        {
            Debug.Log("False");
        }
    }

    public int as04Score;
    public void As04_GetGrade()
    {
        if (as04Score >= 80)
        {
            Debug.Log("A");
        }
        else if (as04Score >= 70)
        {
            Debug.Log("B");
        }
        else if (as04Score >= 60)
        {
            Debug.Log("C");
        }
        else if (as04Score >= 50)
        {
            Debug.Log("D");
        }
        else
        {
            Debug.Log("F");
        }
    }

    public int as05Year;
    public void As05_IsLeapYear()
    {
        if ((as05Year % 400 == 0) ||
            (as05Year % 4 == 0 && as05Year % 100 != 0))
        {
            Debug.Log("True");
        }
        else
        {
            Debug.Log("False");
        }
    }

    public double as06Num1;
    public char as06Op;
    public double as06Num2;
    public void As06_Calculate()
    {
        switch (as06Op)
        {
            case '+':
                Debug.Log("Result: " + (as06Num1 + as06Num2));
                break;

            case '-':
                Debug.Log("Result: " + (as06Num1 - as06Num2));
                break;

            case '*':
                Debug.Log("Result: " + (as06Num1 * as06Num2));
                break;

            case '/':
                if (as06Num2 != 0)
                {
                    Debug.Log("Result: " + (as06Num1 / as06Num2));
                }
                else
                {
                    Debug.Log("Cannot divide by zero");
                }
                break;

            default:
                Debug.Log("Invalid operator");
                break;
        }
    }

    public int as07Month;
    public void As07_GetSeason()
    {
        if (as07Month == 12 || as07Month == 1 || as07Month == 2)
        {
            Debug.Log("Winter");
        }
        else if (as07Month >= 3 && as07Month <= 5)
        {
            Debug.Log("Spring");
        }
        else if (as07Month >= 6 && as07Month <= 8)
        {
            Debug.Log("Summer");
        }
        else if (as07Month >= 9 && as07Month <= 11)
        {
            Debug.Log("Autumn");
        }
        else
        {
            Debug.Log("Invalid month");
        }
    }

    public int as08Quantity;
    public int as08Price;
    public int as08Payment;
    public void As08_PurchasingSystemExample()
    {
        int totalPrice = as08Quantity * as08Price;

        if (as08Payment >= totalPrice)
        {
            int change = as08Payment - totalPrice;

            Debug.Log("Purchase successful");
            Debug.Log("Total: " + totalPrice);
            Debug.Log("Change: " + change);
        }
        else
        {
            int missing = totalPrice - as08Payment;

            Debug.Log("Not enough money");
            Debug.Log("Need more: " + missing);
        }
    }

    public int as09UserChoice;
    public int as09ComputerChoice;
    public void As09_RockPaperScissorsExample()
    {
        if (as09UserChoice == as09ComputerChoice)
        {
            Debug.Log("Draw");
        }
        else if (
            (as09UserChoice == 1 && as09ComputerChoice == 3) ||
            (as09UserChoice == 2 && as09ComputerChoice == 1) ||
            (as09UserChoice == 3 && as09ComputerChoice == 2)
        )
        {
            Debug.Log("You Win");
        }
        else
        {
            Debug.Log("You Lose");
        }
    }

    public string as10WeaponType;
    public int as10BaseDamage;
    public void As10_CalculateWeaponDamage()
    {
        int finalDamage = as10BaseDamage;

        if (as10WeaponType == "Sword")
        {
            finalDamage += 10;
        }
        else if (as10WeaponType == "Bow")
        {
            finalDamage += 5;
        }
        else if (as10WeaponType == "Staff")
        {
            finalDamage += 15;
        }

        Debug.Log("Final Damage: " + finalDamage);
    }

    public int as11Score;
    public int as11CompletionTime;
    public void As11_DeterminePlayerRank()
    {
        if (as11Score >= 100 && as11CompletionTime <= 60)
        {
            Debug.Log("S Rank");
        }
        else if (as11Score >= 80 && as11CompletionTime <= 120)
        {
            Debug.Log("A Rank");
        }
        else if (as11Score >= 60)
        {
            Debug.Log("B Rank");
        }
        else
        {
            Debug.Log("C Rank");
        }
    }
}
