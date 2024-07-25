using System;
using System.Text;

public class PhonePad
{
    private static readonly string[] KeyMappings = 
    {
        " ",    // 0
        "",     // 1
        "ABC",  // 2
        "DEF",  // 3
        "GHI",  // 4
        "JKL",  // 5
        "MNO",  // 6
        "PQRS", // 7
        "TUV",  // 8
        "WXYZ", // 9
        "",     // *
        "",     // #
    };

    public static string OldPhonePad(string input)
    {
        StringBuilder output = new StringBuilder();
        int lastButton = -1;
        int pressCount = 0;

        foreach (char c in input)
        {
            if (c == '#') break; // Send button indicates end of input

            if (c == '*')
            {
                // Handle backspace
                if (output.Length > 0)
                {
                    output.Length--;
                }
                lastButton = -1;
                pressCount = 0;
                continue;
            }

            if (char.IsWhiteSpace(c))
            {
                // Space indicates a pause, reset last button press tracking
                lastButton = -1;
                pressCount = 0;
                continue;
            }

            int button = c - '0';

            if (button < 0 || button > 9) continue; // Ignore invalid input

            if (button == lastButton)
            {
                pressCount++;
            }
            else
            {
                if (lastButton != -1)
                {
                    string mapping = KeyMappings[lastButton];
                    if (mapping.Length > 0)
                    {
                        output.Append(mapping[(pressCount - 1) % mapping.Length]);
                    }
                }

                lastButton = button;
                pressCount = 1;
            }
        }

        if (lastButton != -1)
        {
            string mapping = KeyMappings[lastButton];
            if (mapping.Length > 0)
            {
                output.Append(mapping[(pressCount - 1) % mapping.Length]);
            }
        }

        return output.ToString();
    }
}

// Example usage
class Program
{
    static void Main()
    {
        Console.WriteLine(PhonePad.OldPhonePad("33#")); // Output: E
        Console.WriteLine(PhonePad.OldPhonePad("227*#")); // Output: B
        Console.WriteLine(PhonePad.OldPhonePad("4433555 555666#")); // Output: HELLO
        Console.WriteLine(PhonePad.OldPhonePad("8 88777444666*664#")); // Output: ????
    }
}
