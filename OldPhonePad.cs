using System;
using System.Collections.Generic;
using System.Text;

public class OldPhonePadSimulator
{
    //input into text
    public static string OldPhonePad(string input)
    {
        // Dictionary mapping numbers to letters(Can use alternative Arry,Swich Case)
        Dictionary<char, string> keypad = new Dictionary<char, string>
        {
            {'2', "ABC"}, {'3', "DEF"}, {'4', "GHI"},
            {'5', "JKL"}, {'6', "MNO"}, {'7', "PQRS"},
            {'8', "TUV"}, {'9', "WXYZ"}
        };

        StringBuilder output = new StringBuilder();  // For efficient string manipulation(Can use Sring Concatenation or List of Characters )
        char lastDigit = '\0';  // Tracks the last digit pressed
        int pressCount = 0;     // Tracks how many times a key has been pressed

        foreach (char ch in input)//User for simple Syntax and Safe Iteration(can use also for loop or While loop)
        {
            if (ch == '#')
            {
                // Send button, return the final output
                break;
            }
            else if (ch == '*')
            {
                // Backspace, remove the last character if it exists
                if (output.Length > 0)
                {
                    output.Length--;
                }
                lastDigit = '\0';  // Reset the last digit
                pressCount = 0;    // Reset press count
            }
            else if (ch == ' ')
            {
                // Space represents a pause, reset last digit and press count
                lastDigit = '\0';
                pressCount = 0;
            }
            else if (keypad.ContainsKey(ch))
            {
                // If the same digit is pressed again, increment press count
                if (ch == lastDigit)
                {
                    pressCount++;
                }
                else
                {
                    // New digit is pressed, reset press count
                    lastDigit = ch;
                    pressCount = 1;
                }

                // Calculate which letter to select based on the number of presses
                string letters = keypad[ch];
                int letterIndex = (pressCount - 1) % letters.Length;
                char selectedLetter = letters[letterIndex];

                // Replace or append the selected letter to output
                if (output.Length > 0 && output[output.Length - 1] == selectedLetter)
                {
                    output[output.Length - 1] = selectedLetter;  // Update the last character
                }
                else
                {
                    output.Append(selectedLetter);  // Add new character
                }
            }
        }

        return output.ToString();
    }
}
