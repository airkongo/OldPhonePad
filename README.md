# Old Phone Pad Coding Challenge
## Description
This C# application simulates an old phone keypad to convert sequences of button presses into text. The keypad includes letters, a backspace key (*), and a send button (#). Each button on the keypad represents multiple letters, and pressing a button multiple times cycles through the letters associated with that button.

##Features
Character Mapping: Maps button sequences to their corresponding letters based on the old phone keypad layout.
Backspace Handling: Correctly processes backspace (*) to remove the last character from the output.
Pause Handling: Recognizes space ( ) as a pause to finalize the current sequence before starting a new one.
Send Button Handling: Processes the send button (#) to finalize the input and generate the output string.

## Keypad Layout
2: ABC
3: DEF
4: GHI
5: JKL
6: MNO
7: PQRS
8: TUV
9: WXYZ

## Usage
### Method

`public static string OldPhonePad(string input)`

## Parameters
input (string): The input string consisting of digits, spaces, backspace (*), and send button (#).

##Returns
A string representing the decoded text from the input.

### Example

`Console.WriteLine(PhonePad.OldPhonePad("33#"));          // Output: E
Console.WriteLine(PhonePad.OldPhonePad("227*#"));        // Output: B
Console.WriteLine(PhonePad.OldPhonePad("4433555 555666#")); // Output: HELLO
Console.WriteLine(PhonePad.OldPhonePad("8 88777444666*664#")); // Output: TURING`

## Implementation Details
Button Press Handling: Keeps track of the current button and the number of presses to determine the correct character.
Backspace Processing: Removes the last character from the output if the backspace (*) is encountered.
Space Handling: Finalizes the current sequence of button presses on encountering a space.
Send Button Handling: Completes the current input sequence on encountering the send button (#).

## Testing
The code includes test cases to verify the correctness of the implementation. Ensure that all tests pass to validate the functionality.

## Documentation
The code is documented with comments to explain the logic and implementation details. Please review the code and documentation for a comprehensive understanding.
