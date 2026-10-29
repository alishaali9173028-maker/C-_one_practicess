# C# File System – Windows Forms Application

## Project Description

This project is a **C# Windows Forms Application** that demonstrates how to perform basic file operations using the `System.IO` namespace.

The application allows users to create, write, append, read, and delete text files using different C# file-handling methods.

The main purpose of this project is to understand how file management works in C# and how to use different methods from the `File`, `StreamWriter`, `StreamReader`, and `Path` classes.

## Technologies Used

- Programming Language: C#
- Framework: Windows Forms
- IDE: Visual Studio
- Namespace: `System.IO`
- User Interface: Buttons, ListBox, and MessageBox

## Project Features

### 1. Create New File

**Button:** `buttcreatingnewfile`

**Method:** `File.CreateText()`

This button creates a new text file using the specified file path.

It uses `StreamWriter` to write two lines into the file:

- Welcome to C# File System
- This is the second line.

After creating the file, a success message is displayed.

### 2. Create File Using Path

**Button:** `buttusingpath`

**Method:** `Path.Combine()`

This button demonstrates how to combine a folder path with a file name.

It creates a new text file and writes a message inside it.

The `Path.Combine()` method helps construct file paths correctly.

### 3. Append Text to File

**Button:** `buttappendthefile`

**Method:** `File.AppendAllText()`

This button adds new text to an existing file without deleting its previous content.

The following text is appended:

`Appended new text.`

A confirmation message appears after the operation.

### 4. Read Text File

**Button:** `buttreadtext`

**Method:** `File.ReadAllText()`

This button reads the entire content of a text file.

Before reading, the program checks whether the file exists using `File.Exists()`.

If the file exists, its content is displayed in `listBox1`.

Otherwise, a message indicates that the file was not found.

### 5. Read First Line

**Button:** `buttreadline`

**Method:** `StreamReader.ReadLine()`

This button reads only the first line of the text file.

The result is displayed in the ListBox.

If the file is empty, the program displays `No data`.

### 6. Read First Character

**Button:** `buttusingread`

**Method:** `StreamReader.Read()`

This button reads the first character from the file.

The method returns the character as an integer value, which is converted into a character using `(char)`.

If the file is empty, the application displays `File is empty`.

### 7. Read to End

**Button:** `buttreadend`

**Method:** `StreamReader.ReadToEnd()`

This button reads all remaining text from the current position to the end of the file.

The complete content is displayed in `listBox1`.

### 8. Read All Lines

**Button:** `buttreadallline`

**Method:** `File.ReadAllLines()`

This button reads every line from the file and stores the lines in a string array.

A `foreach` loop is used to display each line separately in the ListBox.

### 9. Peek Next Character

**Button:** `buttpeek`

**Method:** `StreamReader.Peek()`

This button checks the next available character without moving the reading position.

If a character is available, it is displayed in the ListBox.

If the file is empty, the program displays `No character available`.

### 10. Read All Bytes

**Button:** `buttreadallbytes`

**Method:** `File.ReadAllBytes()`

This button reads the file content as an array of bytes.

It calculates the total number of bytes using `data.Length`.

The total byte count is displayed in the ListBox.

### 11. Delete File

**Button:** `button2`

**Method:** `File.Delete()`

This button deletes the specified file from the computer.

Before deleting, the program checks whether the file exists.

If the file exists, it is deleted and a success message is displayed.

Otherwise, the application displays `File does not exist!`.

## Important C# Classes and Methods

| Class / Method | Description |
|---|---|
| `File.CreateText()` | Creates or overwrites a text file |
| `Path.Combine()` | Combines folder and file paths |
| `File.AppendAllText()` | Adds text to a file |
| `File.ReadAllText()` | Reads the entire file as text |
| `StreamReader.ReadLine()` | Reads one line |
| `StreamReader.Read()` | Reads the next character |
| `StreamReader.ReadToEnd()` | Reads all remaining text |
| `File.ReadAllLines()` | Reads all lines into an array |
| `StreamReader.Peek()` | Checks the next character |
| `File.ReadAllBytes()` | Reads the file as bytes |
| `File.Delete()` | Deletes a file |
| `File.Exists()` | Checks whether a file exists |

## File Path Configuration

The application uses a file path to locate the text file.

Example:

```csharp
string path = @"C:\Users\hp\Desktop\C##_one_practicess\C##_one_practicess\assigment_folder\myfile.txt";
```

The path must be updated if the project is used on a different computer.

The folder must exist before the program creates the file.

## How to Run the Project

1. Open Visual Studio.
2. Open the C# Windows Forms project.
3. Open `Form1.cs`.
4. Configure the file path.
5. Make sure the destination folder exists.
6. Build and run the application.
7. Click the buttons to perform different file operations.
8. View file content and results in the ListBox or MessageBox.

## Learning Outcomes

By completing this project, I learned how to:

- Create text files using C#.
- Write and append data to files.
- Read files using different methods.
- Use `StreamWriter` and `StreamReader`.
- Work with file paths.
- Check whether files exist.
- Read file content as bytes.
- Delete files.
- Display results using Windows Forms controls.
- Use the `System.IO` namespace for file management.

## Conclusion

This project demonstrates the basic concepts of file handling in C# Windows Forms.

It provides practical experience with creating, writing, reading, appending, and deleting files.

The project also helps improve understanding of file management, event-driven programming, and user interface development in C#.