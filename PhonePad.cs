using System;
using System.Collections.Generic;
using System.Text;

public class PhonePad
{
    public static string OldPhonePad(string input)
    {
        // Dictionary to map number to its corresponding letters
        var keyMap = new Dictionary<char, string>
        {
            { '1', "" }, { '2', "ABC" }, { '3', "DEF" },
            { '4', "GHI" }, { '5', "JKL" }, { '6', "MNO" },
            { '7', "PQRS" }, { '8', "TUV" }, { '9', "WXYZ" },
            { '0', " " } // assuming '0' corresponds to space
        };

        StringBuilder result = new StringBuilder();
        char currentButton = '\0';
        int pressCount = 0;

        foreach (char ch in input)
        {
            if (ch == '#')
            {
                // End of input
                break;
            }
            else if (ch == '*')
            {
                // Backspace
                if (result.Length > 0)
                {
                    result.Length--;
                }
                // After backspace, we reset the current button and press count
                currentButton = '\0';
                pressCount = 0;
            }
            else if (ch == ' ')
            {
                // Pause
                if (currentButton != '\0' && pressCount > 0)
                {
                    string letters = keyMap[currentButton];
                    int index = (pressCount - 1) % letters.Length;
                    result.Append(letters[index]);
                }
                // Reset current button and press count
                currentButton = '\0';
                pressCount = 0;
            }
            else
            {
                if (ch == currentButton)
                {
                    // Same button pressed again
                    pressCount++;
                }
                else
                {
                    // Different button pressed
                    if (currentButton != '\0' && pressCount > 0)
                    {
                        string letters = keyMap[currentButton];
                        int index = (pressCount - 1) % letters.Length;
                        result.Append(letters[index]);
                    }
                    // Reset for the new button
                    currentButton = ch;
                    pressCount = 1;
                }
            }
        }

        // Add the last character if needed
        if (currentButton != '\0' && pressCount > 0)
        {
            string letters = keyMap[currentButton];
            int index = (pressCount - 1) % letters.Length;
            result.Append(letters[index]);
        }

        return result.ToString();
    }
}

// Example usage
class Program
{
    static void Main()
    {
        Console.WriteLine(PhonePad.OldPhonePad("33#")); // Output: E
        Console.WriteLine(PhonePad.OldPhonePad("227 *#")); // Output: B
        Console.WriteLine(PhonePad.OldPhonePad("4433555 555666#")); // Output: HELLO
        Console.WriteLine(PhonePad.OldPhonePad("8 88777444666 *664#")); // Output: TURING
    }
}
