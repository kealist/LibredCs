# Simple LibRed Binding for C#

This project allows the usage of [Red programming language](http://www.red-lang.org/) in C#.   Currently it exists in it's simplest state--allowing users to directly call library functions.  Review the [documentation for LibRed](https://doc.red-lang.org/en/libred.html) to see the functions provided.   

A more native interface is coming to use common C# types under the hood.

# (Not yet Private) Interface

Review the [documentation for LibRed](https://doc.red-lang.org/en/libred.html).  Until the public interface is made available, dll function calls are available by calling `Red.[functionName]()`.  These do not follow standard naming conventions in C#.

# Public Interface

Until more features are developed, this is most useful for running Red code in a string or file

Initialize the Red runtime by calling `Red.OpenRuntime()`.  Close it & free resources by calling `Red.CloseRuntime()`.

Run Red code as a string (`Red.Do(string redCode)`) or a file (`Red.DoFile(string filePath)` - You must use Red conventions for the path of the file):

    Red.Do("view [text {hello}]");  //This creates a new window with a textbox
    Red.DoFile("/c/dev/red/demo.red");  //This runs the specified file
