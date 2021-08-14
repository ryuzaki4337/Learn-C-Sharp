# Learn-C-Sharp
In this repo, you'll learn how to code using C# (C-Sharp).

## Basics

### Introduction

#### C# vs .NET:

C# is a programming language, while .NET is a framework. It consists of a run-time environment (CLR) and a class library that we use for building applications.

#### CLR

When you compile an application, C# compiler compiles your code to IL (Intermediate Language) code. IL code is platform agnostics, which makes it possible to a take a C# program on a different computer with different hardware architecture and operating system and run it. For this to happen, we need CLR. When you run a C# application, CLR compiles the IL code into the native machine code for the computer on which it is running. This process is called Just-in-time Compilation (JIT).

#### Architecture of .NET Applications

In terms of architecture, an application written with C# consists of building blocks called classes. A class is a container for data (attributes) and methods (functions). Attributes represent the state of the application. Methods include code. They have logic. That's where we implement our algorithms and write code.

A namespace is a container for related classes. So as your application grows in size, you may want to group the related classes into various namespaces for better maintainability.

As the number of classes and namespaces even grow further, you may want to physically separate related namespaces into separate assemblies. An assembly is a file (DLL or EXE) that contains one or more namespaces and classes. An EXE file represents a program that can be executed. A DLL is a file that includes code that can be re-used across different programs.

#### Installation

Follow this link for installaing C# in VSCode : https://channel9.msdn.com/Blogs/dotnet/Get-started-VSCode-Csharp-NET-Core-Windows

### Primitive Types and Expressions

#### Variables and Constants

Variable : A name given to a storage location in memory.
Constant : An immutable value. Used inorder to increase security.

C# is a case-sensitive language. You cannot use a variable without initializing it. 

Constants are declared using "const". Pascal Case is the recommended naming convention for constant variable and Camel case for normal variables.

Incase of a variable overflow, we can use "checked" keyword for avoiding the overflow. But the code throws an exception.

By using the 'var' keyword, the C# compiler automatically detects the type of the variable.

Format specifiers in  C# are given using {0}, {1}, etc.

#### Type Conversion

##### Implicit Type Conversion

Short data types can be converted to larger data types. For example, a byte can converted into an integer without type casting etc.

##### Explicit Type Conversion

When we try to convert larger data types into smaller data types, then the compiler throws an error, to avoid this we use "type-cating".

##### Non-Compatible Types

For non-compatible types like int and string, we can use Convert.ToInt32() or Parse.int() to convert a string into integer.

#### Operators

##### Arithmetic Operators

+, - , *, /, %, ++, --

##### Comparision Operators

==, !=, > , >= , < , <=

##### Assignment Operators

=, +=, -=, *=, /=

##### Logical Operators

&&, ||, !

##### Bitwise Operators

&, |

#### Comments

Inline comments can be written using // ... 

Multiline comments can be written using /* ... */

### Non-primitive Types

#### Classes

Combines related variables(fields) and functions(methods).

Objects are instances of a class.

To create a class we need to have a "access modifier" such as public, private etc.

Similar to other languages, we use "new" keyword to create a new object instance.

##### Static Modifier

By adding "static" keyword, we don't need to create an object.

#### Structs

Similar to classes, we can use Structures. Declare using the "struct" keyword.

#### Arrays

Array : A data structure to store a collection of variables of the same type.

When we declare an array, we need to give the size of the array and also by using "new" keyword.

We can access arrays using [] notation.

When we declare an array, all the elements of the array are set to a default value of the data type.

In C#, we have single and multi dimensional arrays.

We have two types of multi-dimensional arrays i.e. Rectangular and Jagged arrays.

Some of the properties which are used in C# Arrays are:

length, clear(), copy(), IndexOf(), Reverse(), Sort() etc.


#### Strings
 
String : A sequence of characters.

We can concatenate strings using '+'.

We can create strings using "format" method.

We can also create strings using the "join" method.

Each character can be accessed using [].

Strings are immutable.

##### Formatting 

ToLower() : Converts all the characters to lower case.
ToUpper() : Converts all the characters to upper case.
Trim() : Trims all the trailing and leading spaces in the string.


##### Searching

IndexOf(char/string) : Returns the index of the object.
LastIndexOf(string/char) : Returns the last index of the object.

##### Substrings

Substring(startIndex) : Returns a substring starting from the startIndex till the end of the string.
Substring(startIndex,length) : Returns a substring of specified length from the startIndex.

##### Replace

Replace(ToBeReplaced, Into) : Returns the string with the characters/substrings replaced.

##### Null Checking

String.IsNullOrEmpty(str) : Checks whether the string is null or empty.
String.IsNullOrWhiteSpace(str) : Checks whether the string is null or it has white spaces.

##### Split

str.split(' ') : Splits the string using the characters/substrings, it returns an array of substrings.

##### Converting Strings to Numbers

To convert a string to integer, we can use int.Parse(str) or Convert.ToInt32(str) . 

Convert.ToInt32(str) is recommended as it returns a default value, if the string is null or empty.

##### Converting Numbers to Strings

To convert a number into strings, we can use .ToString() 

##### Escape Characters

\n : New line
\t : Tab
\\ : BackSlash
\' : Single Quotation Mark
\" : Double Quotation Mark

Verbatim Strings are used to avoid confusion while using '\'. For example, the path of a directory etc. To create a verbatim, just put @ at the beginning of the string.

#### String Builder 

Defined in System.Text

A mutable string.

Easy and faster to create and manipulate strings. It is not recommended to use for searching.

 
 
#### Enums

Enum : A set of name/value pairs (constants).

We can create a enum using "enum" keyword.

Enums are used for shipping methods etc.

If we don't set values to enums, then the values are set automatically from zero.

#### Values Types vs. Reference Types

##### Value Types

Structures,
Primitive Types are declared,
Allocated on Stack,
Memory allocation done automatically,
Immediately removed when out of scope.

##### Reference Types

Classes,
Non-primitive Types are declared,
You need to allocate memory,
Memory allocated on heap,
Garbage collected by CLR.

### Control Flow

#### Conditional Statements

##### If/else Statements

 If the condition in the "if" keyword is true, then the statements in the "if" block get executed, else if the condition in the "else if" keyword is true, then the statements in the "else if" block get executed, otherwise the statements in the "else" block get executed.
 
 We can also nested if/else if statements.
 
##### Switch/case Statements

Unlike if/else, a variable used in the "switch" statement is compared using "cases", if any case matches then the statements in that block get executed. "default" keyword's block statements get executed if none of the cases match. 

We need to be very careful with the "break" statement. 

#### Iteration Statements

##### For loops

The "for" statement has three parts, initialisation clause, condition clause and the iteration clause. If the condition in the condition clause is satisified, then the set of statements under the "for" block get executed.

##### Foreach loops

For each is used to iterate over elements of an enumerable object.
We can use this loop using the 'foreach' keyword.

##### While loops

Similar to for loop, "while" loop's initialisation clause is outside the while loop, conditional clause is used with the while keyword and iteration clause within the while block. If the condition inside the conditional clause is satisified, then the statements inside the while loop get executed.

##### Do-while loops

Similar to the while loop, the "do-while loop" has the while statement at the end of the loop.


##### Break and Continue

Break : Jumps out of the loop.
continue : jumps to the next iteration.

### Random Class

Random Class in C# is used to generate random numbers.

### Lists

List : Dynamic Sized data structure.

### Working with Dates

There is a class called "DateTime" in the system. 

Using the .Now method, we can get the present time and using .Today, we can get Today's date.

Once a date object has been created, we cannot change it. But with can change them using the Add functions.

Intellisense in Vscode displays a lot of specifiers on printing a date.

### Working with Files

All the file related methods are stored in System.IO library.

File, FileInfo : Provide Methods for creating, copying, deleting, moving and opening of files.

FileInfo provides instance methods, whereas File provides static methods.

Directory, DirectoryInfo : Similar to the above.
Directory provides static methods, whereas the DirectoryInfo provides instance methods.

Path class provides methods to work with a string that contains a file or directory path information.

FileInfo doesn't have static members to work with files. It represents a single file.

Security checking is done only during instantiation of FileInfo, and that's why it's more efficient than File if you're executing multiple operations on a given file. Because security checking will be done only once.


## Intermediate

### Classes

Class : A building block of an application.

Anatomy of a Class: Data(Variables) and Behaviour(methods).

Object : An instance of a class.

Class name is recommended to be in PascalCase.

#### Class Members

Instance : Accessible from an object.

Static : accessible from the class. Eg : Console.WriteLine().

We can use "static" keyword to declare a member as static.

We can create an object of a class, inside the same class.

#### Constructors

A method that is called when an instance of a class is created.

The use of a constructor is to put an object in an early state.

The Constructor have the same name of the class.

"this" keyword is used to avoid the confusion between the variables have the same name.

Constructor Overloading : The constructors have the same name, but different parameters.

If a member is not initialised in a class, then the default constructor assigns a default value to the member.

#### Object Initializers

A syntax for quickly initializing an object without the need to call one of its constructors.

It is used to avoid creating multiple constructors.

#### Methods

Signature of a method : Name , Number and Type of parameters.

Overloading Methods : Having a method with the same name but different signatures.

"Params" keyword is used before parameters instead of using the "new" keyword.
 
"ref" keyword is used before parameters to convert a value type into references types.

"out" keyword is similar to "ref" keyword but it has other disadvantages.

'ref' and 'out' are not recommended to practice.

#### Fields

Fields : Variables in the class

To make a field readOnly, we can use "readonly" keyword. This is used to increase robustness.

#### Access Modifiers

Access Modifiers : A way to control access to a class and/or its members. There are used to create safety in our programs.

Access Modifiers are of five types : Public, Private, Protected, Internal, Protected Internal.

Public : The members of the class can be used anywhere.

Private : The members of the class can be accessed or used in the class. The naming convention of the private fields starts with an underscore and must be camel case.

#### Property 

A class members that encapsulates a getter/setter for accessing a field. It is used to create a getter/setter for less code.

In terms of naming convention, we should Pascal case for properties.

#### Indexers

A way to access elements in a class that represents a list of values.

An indexer is defined similar to a property but the name of the method must always be "this" and should have [] not ().


### Object Oriented Programming 

#### Encapsulation : 

Define fields as private.

Provide getter/setter methods as public.

