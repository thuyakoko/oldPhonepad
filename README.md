
# Old Phone Pad Simulator

## Overview

This project mimics how an old mobile phone keypad works. It takes a string of key presses as input and gives back the matching text. On old phones, each number key (2-9) represents several letters, and you’d press the key multiple times to select the letter you want.


The input also supports:
- `*` for backspace (removing the last character)
- `#` to signal the end of input (like a send button).
- A space ' ' for pausing between key presses on the same key (e.g., "222 2" becomes "CAB").

## Features
- Simulates typing using an old mobile phone keypad.
- Supports deleting characters with *.
- Handles pauses between key presses.
- Returns the text based on the input.

## Examples

```c#
OldPhonePadSimulator.OldPhonePad("33#");            // Returns: "E"
OldPhonePadSimulator.OldPhonePad("227*#");          // Returns: "B"
OldPhonePadSimulator.OldPhonePad("4433555 555666#"); // Returns: "HELLO"
OldPhonePadSimulator.OldPhonePad("8 88777444666*664#"); // Returns: "TOOL"
```

## How to Use

1. **Clone the repository**:
    ```
    git clone https://github.com/thuyakoko/oldPhonepad.git
    ```

2. **Compile the code**:
    - Open the project in Visual Studio or any C# IDE.
    - Build the solution.

3. **Run the tests**:
    - Use NUnit to run the test suite provided in the `OldPhonePadTests` class.

## Test Cases

Here are some basic test cases included in the `OldPhonePadTests.cs` file:

```c#
[Test]
public void TestSingleKeyPress()
{
    Assert.AreEqual("E", OldPhonePadSimulator.OldPhonePad("33#"));
}

[Test]
public void TestWithBackspace()
{
    Assert.AreEqual("B", OldPhonePadSimulator.OldPhonePad("227*#"));
}

[Test]
public void TestLongerInput()
{
    Assert.AreEqual("HELLO", OldPhonePadSimulator.OldPhonePad("4433555 555666#"));
}
```


