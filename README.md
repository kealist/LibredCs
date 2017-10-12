# Simple LibRed Binding for C#

This project allows the usage of [Red programming language](http://www.red-lang.org/) in C#.   Currently it exists in it's simplest state--allowing users to directly call library functions.  Review the [documentation for LibRed](https://doc.red-lang.org/en/libred.html) to see the functions provided.   

A more native interface is coming to use common C# types under the hood (including standard capitalization of names)

# Usage

Until more features are developed, this is most useful for running Red code in a string or file

Initialize the Red runtime by calling `Red.redOpen()`.  Close it & free resources by calling `Red.redClose()`.

Run Red code as a string (`Red.redDo`) or a file (`Red.RedDoFile` - You must use Red conventions for the path of the file):

`Red.redDo("view [text {hello}]");  //This creates a new window with a textbox`
`redDoFile("/c/dev/red/demo.red");  //This runs the specified file
