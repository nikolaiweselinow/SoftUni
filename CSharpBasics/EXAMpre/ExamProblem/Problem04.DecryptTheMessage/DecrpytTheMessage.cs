using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DecrpytTheMessage
{
    static void Main()
    {
        string inputString = string.Empty;
        //int msgCounter = 0; //брояч на съобщенията //махаме го защото List-a има брояч!

        //Сега ще си направим LIST, защото не знаем колко точно ще е дължината на стринга
        List<string> msger = new List<string>();

        do
        {
            inputString = Console.ReadLine(); //Докато потребителя не въведе START!
        } while (inputString.ToUpper() != "START");

        inputString = Console.ReadLine();
        while (inputString.ToUpper() != "END")
        {
            string decpyptedMsg = "";
            if (inputString != "") //ако не е празен ще го декриптираме!
            {
                                
                for (int symbol = 0; symbol < inputString.Length; symbol++)
                {
                    if (
                        (inputString[symbol] >= 'A') && (inputString[symbol] <= 'Z') ||
                        (inputString[symbol] >= 'a') && (inputString[symbol] <= 'z')
                       )
                    {
                        if (
                            (inputString[symbol] >= 'A') && (inputString[symbol] <= 'M') ||
                            (inputString[symbol] >= 'a') && (inputString[symbol] <= 'm')
                           )
                        {
                            decpyptedMsg = decpyptedMsg + (char)(inputString[symbol] + 13);
                        }
                        else
                        {
                            decpyptedMsg = decpyptedMsg + (char)(inputString[symbol] - 13);
                        }
                    }
                    else
                    {
                        switch (inputString[symbol])
                        {
                            case '+':
                                decpyptedMsg += ' ';
                                break;
                            case '%':
                                decpyptedMsg += ',';
                                break;
                            case '&':
                                decpyptedMsg += '.';
                                break;
                            case '#':
                                decpyptedMsg += '?';
                                break;
                            case '$':
                                decpyptedMsg += '!';
                                break;
                            default:
                                decpyptedMsg += inputString[symbol];
                                break;
                        }
                    }
                }
            }

            char[] reversedArray = decpyptedMsg.ToCharArray();
            Array.Reverse(reversedArray);
            decpyptedMsg = new string(reversedArray);

            msger.Add(decpyptedMsg);

            inputString = Console.ReadLine();
        }

        if (msger.Count != 0)
        {
            Console.WriteLine("Total number of messages: {0}", msger.Count);
            foreach (var msg in msger)
            {
                Console.WriteLine(msg);
            }
        }
        else
        {
            Console.WriteLine("No message received.");
        }
    }
}


